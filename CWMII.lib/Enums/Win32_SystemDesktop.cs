namespace CWMII.lib.Enums {
	public enum Win32_SystemDesktop {
		Element,
		Setting
	}

	public static class Win32_SystemDesktopExtension {
		public static string GetWMIValue(this Win32_SystemDesktop enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemDesktop", enumOption.ToString());
	}
}