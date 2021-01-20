namespace CWMII.lib.Enums {
	public enum Win32_PnPSignedDriverCIMDataFile {
		Antecedent,
		Dependent
	}

	public static class Win32_PnPSignedDriverCIMDataFileExtension {
		public static string GetWMIValue(this Win32_PnPSignedDriverCIMDataFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PnPSignedDriverCIMDataFile", enumOption.ToString());
	}
}