namespace CWMII.lib.Enums {
	public enum Win32_SoftwareElementAction {
		Action,
		Element
	}

	public static class Win32_SoftwareElementActionExtension {
		public static string GetWMIValue(this Win32_SoftwareElementAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareElementAction", enumOption.ToString());
	}
}