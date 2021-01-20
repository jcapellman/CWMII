namespace CWMII.lib.Enums {
	public enum Win32_Reliability {
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

	public static class Win32_ReliabilityExtension {
		public static string GetWMIValue(this Win32_Reliability enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Reliability", enumOption.ToString());
	}
}