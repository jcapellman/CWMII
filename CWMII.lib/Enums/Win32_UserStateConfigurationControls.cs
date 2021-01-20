namespace CWMII.lib.Enums {
	public enum Win32_UserStateConfigurationControls {
		FolderRedirection,
		OfflineFiles,
		RoamingUserProfile
	}

	public static class Win32_UserStateConfigurationControlsExtension {
		public static string GetWMIValue(this Win32_UserStateConfigurationControls enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_UserStateConfigurationControls", enumOption.ToString());
	}
}