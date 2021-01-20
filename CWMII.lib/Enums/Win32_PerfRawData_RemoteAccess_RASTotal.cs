namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_RemoteAccess_RASTotal {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AlignmentErrors,
		BufferOverrunErrors,
		BytesReceived,
		BytesReceivedPerSec,
		BytesTransmitted,
		BytesTransmittedPerSec,
		CRCErrors,
		FramesReceived,
		FramesReceivedPerSec,
		FramesTransmitted,
		FramesTransmittedPerSec,
		PercentCompressionIn,
		PercentCompressionOut,
		SerialOverrunErrors,
		TimeoutErrors,
		TotalConnections,
		TotalErrors,
		TotalErrorsPerSec
	}

	public static class Win32_PerfRawData_RemoteAccess_RASTotalExtension {
		public static string GetWMIValue(this Win32_PerfRawData_RemoteAccess_RASTotal enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_RemoteAccess_RASTotal", enumOption.ToString());
	}
}