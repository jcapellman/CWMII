namespace CWMII.lib.Enums {
	public enum Win32_NTLogEvent {
		Category,
		CategoryString,
		ComputerName,
		Data,
		EventCode,
		EventIdentifier,
		EventType,
		InsertionStrings,
		Logfile,
		Message,
		RecordNumber,
		SourceName,
		TimeGenerated,
		TimeWritten,
		Type,
		User
	}

	public static class Win32_NTLogEventExtension {
		public static string GetWMIValue(this Win32_NTLogEvent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTLogEvent", enumOption.ToString());
	}
}