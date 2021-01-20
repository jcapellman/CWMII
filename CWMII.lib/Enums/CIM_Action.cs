namespace CWMII.lib.Enums {
	public enum CIM_Action {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		EntryName,
		EntryValue,
		key,
		Registry,
		Root
	}

	public static class CIM_ActionExtension {
		public static string GetWMIValue(this CIM_Action enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Action", enumOption.ToString());
	}
}