namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NumberofTransmitCompletesPersec,
		NumberofVMQs,
		PacketsfromExternalPersec,
		PacketsfromInternalPersec
	}

	public static class Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessorExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor", enumOption.ToString());
	}
}