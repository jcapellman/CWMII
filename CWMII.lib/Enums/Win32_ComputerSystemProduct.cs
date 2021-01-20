namespace CWMII.lib.Enums {
	public enum Win32_ComputerSystemProduct {
		Caption,
		Description,
		IdentifyingNumber,
		Name,
		SKUNumber,
		Vendor,
		Version,
		UUID
	}

	public static class Win32_ComputerSystemProductExtension {
		public static string GetWMIValue(this Win32_ComputerSystemProduct enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ComputerSystemProduct", enumOption.ToString());
	}
}