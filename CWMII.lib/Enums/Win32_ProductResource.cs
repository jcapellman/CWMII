namespace CWMII.lib.Enums {
	public enum Win32_ProductResource {
		Product,
		Resource
	}

	public static class Win32_ProductResourceExtension {
		public static string GetWMIValue(this Win32_ProductResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProductResource", enumOption.ToString());
	}
}