namespace CWMII.lib.Enums {
	public enum Win32_ComponentCategory {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CategoryId
	}

	public static class Win32_ComponentCategoryExtension {
		public static string GetWMIValue(this Win32_ComponentCategory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ComponentCategory", enumOption.ToString());
	}
}