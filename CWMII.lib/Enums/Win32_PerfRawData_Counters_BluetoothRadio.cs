namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_BluetoothRadio {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		A2dpOffloadConnections,
		ACLflusheventsPersec,
		ClassicACLbytesreadPersec,
		ClassicACLbyteswrittenPersec,
		ClassicACLConnections,
		ClassicACLwritecredits,
		InquiryScanDutyCyclePercent,
		InquiryScanInterval,
		InquiryScanWindow,
		LEACLbytesreadPersec,
		LEACLbyteswrittenPersec,
		LEACLConnections,
		LEACLwritecredits,
		LEScanDutyCyclePercentCodedPhy,
		LEScanDutyCyclePercentUncoded1MPhy,
		LEScanIntervalCodedPhy,
		LEScanIntervalUncoded1MPhy,
		LEScanWindowCodedPhy,
		LEScanWindowUncoded1MPhy,
		PageScanDutyCyclePercent,
		PageScanInterval,
		PageScanWindow,
		SCObytesreadPersec,
		SCObyteswrittenPersec,
		SCOConnections,
		SidebandSCOConnections
	}

	public static class Win32_PerfRawData_Counters_BluetoothRadioExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_BluetoothRadio enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_BluetoothRadio", enumOption.ToString());
	}
}