namespace CWMII.lib.Enums {
	public enum Win32_ClassicCOMClassSetting {
		Caption,
		Description,
		SettingID,
		AppID,
		AutoConvertToClsid,
		AutoTreatAsClsid,
		ComponentId,
		Control,
		DefaultIcon,
		InprocHandler,
		InprocHandler32,
		InprocServer,
		InprocServer32,
		Insertable,
		JavaClass,
		LocalServer,
		LocalServer32,
		LongDisplayName,
		ProgId,
		ShortDisplayName,
		ThreadingModel,
		ToolBoxBitmap32,
		TreatAsClsid,
		TypeLibraryId,
		Version,
		VersionIndependentProgId
	}

	public static class Win32_ClassicCOMClassSettingExtension {
		public static string GetWMIValue(this Win32_ClassicCOMClassSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ClassicCOMClassSetting", enumOption.ToString());
	}
}