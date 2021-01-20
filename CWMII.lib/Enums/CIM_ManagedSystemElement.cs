namespace CWMII.lib.Enums {
	public enum CIM_ManagedSystemElement {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CategoryId
	}

	public static class CIM_ManagedSystemElementExtension {
		public static string GetWMIValue(this CIM_ManagedSystemElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ManagedSystemElement", enumOption.ToString());
	}
}