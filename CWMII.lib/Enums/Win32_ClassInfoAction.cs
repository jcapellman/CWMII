namespace CWMII.lib.Enums {
	public enum Win32_ClassInfoAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		AppID,
		Argument,
		CLSID,
		Context,
		DefInprocHandler,
		FileTypeMask,
		Insertable,
		ProgID,
		RemoteName,
		VIProgID
	}

	public static class Win32_ClassInfoActionExtension {
		public static string GetWMIValue(this Win32_ClassInfoAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ClassInfoAction", enumOption.ToString());
	}
}