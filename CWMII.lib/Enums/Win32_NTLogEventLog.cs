namespace CWMII.lib.Enums {
	public enum Win32_NTLogEventLog {
		Log,
		Record
	}

	public static class Win32_NTLogEventLogExtension {
		public static string GetWMIValue(this Win32_NTLogEventLog enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTLogEventLog", enumOption.ToString());
	}
}