namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Tcpip_NBTConnection {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BytesReceivedPersec,
		BytesSentPersec,
		BytesTotalPersec
	}

	public static class Win32_PerfFormattedData_Tcpip_NBTConnectionExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Tcpip_NBTConnection enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Tcpip_NBTConnection", enumOption.ToString());
	}
}