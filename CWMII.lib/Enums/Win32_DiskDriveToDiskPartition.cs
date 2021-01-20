namespace CWMII.lib.Enums {
	public enum Win32_DiskDriveToDiskPartition {
		Antecedent,
		Dependent
	}

	public static class Win32_DiskDriveToDiskPartitionExtension {
		public static string GetWMIValue(this Win32_DiskDriveToDiskPartition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DiskDriveToDiskPartition", enumOption.ToString());
	}
}