namespace CWMII.lib.Enums {
	public enum Win32_AccountSID {
		Element,
		Setting
	}

	public static class Win32_AccountSIDExtension {
		public static string GetWMIValue(this Win32_AccountSID enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_AccountSID", enumOption.ToString());
	}
}