namespace CWMII.lib.Enums {
	public enum Win32_LogicalDiskToPartition {
		Antecedent,
		Dependent,
		EndingAddress,
		StartingAddress
	}

	public static class Win32_LogicalDiskToPartitionExtension {
		public static string GetWMIValue(this Win32_LogicalDiskToPartition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalDiskToPartition", enumOption.ToString());
	}
}