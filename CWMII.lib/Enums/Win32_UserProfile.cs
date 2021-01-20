namespace CWMII.lib.Enums {
	public enum Win32_UserProfile {
		AppDataRoaming,
		Contacts,
		Desktop,
		Documents,
		Downloads,
		Favorites,
		HealthStatus,
		LastAttemptedProfileDownloadTime,
		LastAttemptedProfileUploadTime,
		LastBackgroundRegistryUploadTime,
		LastDownloadTime,
		LastUploadTime,
		LastUseTime,
		Links,
		Loaded,
		LocalPath,
		Music,
		Pictures,
		RefCount,
		RoamingConfigured,
		RoamingPath,
		RoamingPreference,
		SavedGames,
		Searches,
		SID,
		Special,
		StartMenu,
		Status,
		Videos
	}

	public static class Win32_UserProfileExtension {
		public static string GetWMIValue(this Win32_UserProfile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_UserProfile", enumOption.ToString());
	}
}