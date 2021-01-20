namespace CWMII.lib.Enums {
	public enum Win32_CIMLogicalDeviceCIMDataFile {
		Antecedent,
		Dependent,
		Purpose,
		PurposeDescription
	}

	public static class Win32_CIMLogicalDeviceCIMDataFileExtension {
		public static string GetWMIValue(this Win32_CIMLogicalDeviceCIMDataFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CIMLogicalDeviceCIMDataFile", enumOption.ToString());
	}
}