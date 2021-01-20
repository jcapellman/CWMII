namespace CWMII.lib.Enums {
	public enum Win32_ActionCheck {
		Action,
		Check
	}

	public static class Win32_ActionCheckExtension {
		public static string GetWMIValue(this Win32_ActionCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ActionCheck", enumOption.ToString());
	}
}