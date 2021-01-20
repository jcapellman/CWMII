namespace CWMII.lib.Enums {
	public enum Win32_ShortcutSAP {
		Action,
		Element
	}

	public static class Win32_ShortcutSAPExtension {
		public static string GetWMIValue(this Win32_ShortcutSAP enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ShortcutSAP", enumOption.ToString());
	}
}