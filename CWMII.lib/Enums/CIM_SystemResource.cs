namespace CWMII.lib.Enums {
	public enum CIM_SystemResource {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Availability,
		CreationClassName,
		CSCreationClassName,
		CSName,
		IRQNumber,
		Shareable,
		TriggerLevel,
		TriggerType,
		Hardware,
		Vector
	}

	public static class CIM_SystemResourceExtension {
		public static string GetWMIValue(this CIM_SystemResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SystemResource", enumOption.ToString());
	}
}