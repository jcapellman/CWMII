namespace CWMII.lib.Enums {
	public enum CIM_IRQ {
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

	public static class CIM_IRQExtension {
		public static string GetWMIValue(this CIM_IRQ enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_IRQ", enumOption.ToString());
	}
}