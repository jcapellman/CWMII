# CWMII

Clean WMI Interface (CWMII) written in C# providing a strongly typed interface to access WMI Properties and Classes

NuGet: https://www.nuget.org/packages/CWMII/

A common method of accessing WMI objects is to utilize System.Management, however this creates block of code like so:
```
ManagementObjectSearcher searcher = 
    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS"); 

foreach (ManagementObject queryObj in searcher.Get())
{
    Console.WriteLine("Manufacturer: {0}", queryObj["Manufacturer"]);
}
```

And you've probably created wrapper methods to take a WMI Query as an argument, however this leads to typos and spelling errors in the query itself.

The CWMII interface allows this same query to be simply:
```
CWMII.lib.Enums.Win32_BIOS.Manufacturer.GetWMIValue();
```

If you'd liked mulitple properties of let's say Win32_BIOS:
```
lib.CWMII.GetProperties<Win32_BIOS>();
```

This returns a Dictionary<string,string> where the Key is the property name.
