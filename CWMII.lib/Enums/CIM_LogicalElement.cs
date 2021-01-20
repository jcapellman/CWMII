namespace CWMII.lib.Enums {
	public enum CIM_LogicalElement {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CategoryId
	}

	public static class CIM_LogicalElementExtension {
		public static string GetWMIValue(this CIM_LogicalElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_LogicalElement", enumOption.ToString());
	}
}