namespace CWMII.lib.Enums {
	public enum Win32_ServiceSpecificationService {
		Check,
		Element
	}

	public static class Win32_ServiceSpecificationServiceExtension {
		public static string GetWMIValue(this Win32_ServiceSpecificationService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ServiceSpecificationService", enumOption.ToString());
	}
}