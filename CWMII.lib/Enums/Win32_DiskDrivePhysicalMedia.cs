namespace CWMII.lib.Enums {
	public enum Win32_DiskDrivePhysicalMedia {
		Antecedent,
		Dependent
	}

	public static class Win32_DiskDrivePhysicalMediaExtension {
		public static string GetWMIValue(this Win32_DiskDrivePhysicalMedia enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DiskDrivePhysicalMedia", enumOption.ToString());
	}
}