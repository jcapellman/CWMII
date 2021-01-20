using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Management.Infrastructure;

namespace CWMII.lib
{
    public static class CWMII
    {
        public const string UNKNOWN_VALUE = "<UNKNOWN>";
        
        private const string HIVE = @"\\LOCALHOST\root\cimv2";

        public static Dictionary<string,string> GetProperties<T>() where T : Enum => GetProperties($"SELECT * FROM {typeof(T).Name}");

        public static string GetSingleProperty(string wmiQuery, string propertyName)
        {
            using var session = CimSession.Create(null);

            foreach (var instance in session.QueryInstances(HIVE, "WQL", wmiQuery))
            {
                using (instance)
                {
                    var property = instance.CimInstanceProperties.FirstOrDefault(a => a.Name == propertyName);

                    return property == null ? UNKNOWN_VALUE : property.Value.ToString();
                }
            }

            return UNKNOWN_VALUE;
        }

        public static Dictionary<string, string> GetProperties(string wmiQuery)
        {
            using var session = CimSession.Create(null);

            foreach (var instance in session.QueryInstances(HIVE, "WQL", wmiQuery))
            {
                using (instance)
                {
                    return instance.CimInstanceProperties.ToDictionary(property => property?.Name, property => property?.Value?.ToString());
                }
            }

            return null;
        }
    }
}