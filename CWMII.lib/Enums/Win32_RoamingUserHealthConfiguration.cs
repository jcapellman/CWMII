namespace CWMII.lib.Enums {
	public enum Win32_RoamingUserHealthConfiguration {
		HealthStatusForTempProfiles,
		LastProfileDownloadIntervalCautionInHours,
		LastProfileDownloadIntervalUnhealthyInHours,
		LastProfileUploadIntervalCautionInHours,
		LastProfileUploadIntervalUnhealthyInHours
	}

	public static class Win32_RoamingUserHealthConfigurationExtension {
		public static string GetWMIValue(this Win32_RoamingUserHealthConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_RoamingUserHealthConfiguration", enumOption.ToString());
	}
}