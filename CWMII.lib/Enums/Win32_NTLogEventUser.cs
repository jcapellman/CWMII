namespace CWMII.lib.Enums {
	public enum Win32_NTLogEventUser {
		Record,
		User
	}

	public static class Win32_NTLogEventUserExtension {
		public static string GetWMIValue(this Win32_NTLogEventUser enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTLogEventUser", enumOption.ToString());
	}
}