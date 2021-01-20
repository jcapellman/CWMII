namespace CWMII.lib.Enums {
	public enum Win32_ReliabilityRecords {
		ComputerName,
		EventIdentifier,
		InsertionStrings,
		Logfile,
		Message,
		ProductName,
		RecordNumber,
		SourceName,
		TimeGenerated,
		User
	}

	public static class Win32_ReliabilityRecordsExtension {
		public static string GetWMIValue(this Win32_ReliabilityRecords enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ReliabilityRecords", enumOption.ToString());
	}
}