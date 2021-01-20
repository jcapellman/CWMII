namespace CWMII.lib.Enums {
	public enum Win32_DCOMApplicationSetting {
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

	public static class Win32_DCOMApplicationSettingExtension {
		public static string GetWMIValue(this Win32_DCOMApplicationSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DCOMApplicationSetting", enumOption.ToString());
	}
}