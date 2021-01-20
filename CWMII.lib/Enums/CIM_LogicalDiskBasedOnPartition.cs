namespace CWMII.lib.Enums {
	public enum CIM_LogicalDiskBasedOnPartition {
		Antecedent,
		Dependent,
		EndingAddress,
		StartingAddress
	}

	public static class CIM_LogicalDiskBasedOnPartitionExtension {
		public static string GetWMIValue(this CIM_LogicalDiskBasedOnPartition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_LogicalDiskBasedOnPartition", enumOption.ToString());
	}
}