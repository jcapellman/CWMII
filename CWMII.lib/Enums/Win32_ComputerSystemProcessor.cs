namespace CWMII.lib.Enums {
	public enum Win32_ComputerSystemProcessor {
		GroupComponent,
		PartComponent
	}

	public static class Win32_ComputerSystemProcessorExtension {
		public static string GetWMIValue(this Win32_ComputerSystemProcessor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ComputerSystemProcessor", enumOption.ToString());
	}
}