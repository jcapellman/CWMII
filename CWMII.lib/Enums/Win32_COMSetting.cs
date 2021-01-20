namespace CWMII.lib.Enums {
	public enum Win32_COMSetting {
		Caption,
		Description,
		SettingID,
		AppID,
		AuthenticationLevel,
		CustomSurrogate,
		EnableAtStorageActivation,
		LocalService,
		RemoteServerName,
		RunAsUser,
		ServiceParameters,
		UseSurrogate
	}

	public static class Win32_COMSettingExtension {
		public static string GetWMIValue(this Win32_COMSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_COMSetting", enumOption.ToString());
	}
}