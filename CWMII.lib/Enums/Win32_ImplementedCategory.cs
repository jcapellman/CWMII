namespace CWMII.lib.Enums {
	public enum Win32_ImplementedCategory {
		Category,
		Component
	}

	public static class Win32_ImplementedCategoryExtension {
		public static string GetWMIValue(this Win32_ImplementedCategory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ImplementedCategory", enumOption.ToString());
	}
}