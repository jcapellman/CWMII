namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_WinNatCounters_WinNATInstance {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		TCPPortsAvailable,
		TCPPortsInUse,
		UDPPortsAvailable,
		UDPPortsInUse
	}

	public static class Win32_PerfFormattedData_WinNatCounters_WinNATInstanceExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_WinNatCounters_WinNATInstance enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_WinNatCounters_WinNATInstance", enumOption.ToString());
	}
}