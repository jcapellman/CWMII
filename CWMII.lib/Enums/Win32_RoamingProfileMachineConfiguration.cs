namespace CWMII.lib.Enums {
	public enum Win32_RoamingProfileMachineConfiguration {
		AddAdminGroupToRUPEnabled,
		AllowCrossForestUserPolicy,
		BackgroundUploadParams,
		DeleteProfilesOlderDays,
		DeleteRoamingCacheEnabled,
		DetectSlowLinkDisabled,
		ForceUnloadDisabled,
		IsConfiguredByWMI,
		MachineProfilePath,
		OnlyAllowLocalProfiles,
		OwnerCheckDisabled,
		PrimaryComputerEnabled,
		ProfileUploadDisabled,
		SlowLinkTimeOutParams,
		SlowLinkUIEnabled,
		TempProfileLogonBlocked,
		WaitForNetworkInSec,
		WaitForRemoteProfile
	}

	public static class Win32_RoamingProfileMachineConfigurationExtension {
		public static string GetWMIValue(this Win32_RoamingProfileMachineConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_RoamingProfileMachineConfiguration", enumOption.ToString());
	}
}