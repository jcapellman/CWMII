namespace CWMII.lib.Enums {
	public enum Win32_StartupCommand {
		Caption,
		Description,
		SettingID,
		Command,
		Location,
		Name,
		User,
		UserSID
	}

	public static class Win32_StartupCommandExtension {
		public static string GetWMIValue(this Win32_StartupCommand enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_StartupCommand", enumOption.ToString());
	}
}