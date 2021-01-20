namespace CWMII.lib.Enums {
	public enum Win32_CheckCheck {
		Check,
		Location
	}

	public static class Win32_CheckCheckExtension {
		public static string GetWMIValue(this Win32_CheckCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CheckCheck", enumOption.ToString());
	}
}