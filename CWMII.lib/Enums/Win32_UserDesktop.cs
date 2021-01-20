namespace CWMII.lib.Enums {
	public enum Win32_UserDesktop {
		Element,
		Setting
	}

	public static class Win32_UserDesktopExtension {
		public static string GetWMIValue(this Win32_UserDesktop enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_UserDesktop", enumOption.ToString());
	}
}