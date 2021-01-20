namespace CWMII.lib.Enums {
	public enum Win32_ProductCheck {
		Check,
		Product
	}

	public static class Win32_ProductCheckExtension {
		public static string GetWMIValue(this Win32_ProductCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProductCheck", enumOption.ToString());
	}
}