using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Threading.Tasks;

namespace CWMII.Gen
{
    class Program
    {
        static void GenEnum(string table)
        {
            var directory = Path.Combine(AppContext.BaseDirectory, $"../../../../CWMII.lib/Enums");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            
            var outputPath = Path.Combine(directory, $"{table}.cs");

            var templateText = File.ReadAllText("Template.txt");

            try
            {
                var items = lib.CWMII.GetProperties($"SELECT * FROM {table}");

                if (items == null)
                {
                    throw new Exception();
                }
                
                templateText = templateText.Replace("{TABLE}", table);
                templateText = templateText.Replace("{PROPERTIES}",
                    string.Join($",{Environment.NewLine}\t\t", items.Keys));

                File.WriteAllText(outputPath, templateText);
            }
            catch (Exception)
            {
                Console.WriteLine($"Could not create {table}.cs");
            }
        }
        
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(
                    new ManagementScope(
                        "root\\cimv2"),
                    new WqlObjectQuery(
                        "select * from meta_class"),
                    null);

            var classes = new List<string>();
            
            foreach (ManagementClass wmiClass in
                searcher.Get())
            {
                classes.Add(wmiClass["__CLASS"].ToString());
            }

            Parallel.ForEach(classes, className =>
            {
                GenEnum(className);
            });
        }
    }
}
