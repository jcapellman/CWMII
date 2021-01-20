namespace CWMII.lib.Enums {
	public enum Win32_IRQResource {
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

	public static class Win32_IRQResourceExtension {
		public static string GetWMIValue(this Win32_IRQResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_IRQResource", enumOption.ToString());
	}
}