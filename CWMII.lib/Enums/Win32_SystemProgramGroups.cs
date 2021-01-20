namespace CWMII.lib.Enums {
	public enum Win32_SystemProgramGroups {
		Element,
		Setting
	}

	public static class Win32_SystemProgramGroupsExtension {
		public static string GetWMIValue(this Win32_SystemProgramGroups enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemProgramGroups", enumOption.ToString());
	}
}