namespace CWMII.lib.Enums {
	public enum Win32_ManagedSystemElementResource {
		Element,
		Setting
	}

	public static class Win32_ManagedSystemElementResourceExtension {
		public static string GetWMIValue(this Win32_ManagedSystemElementResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ManagedSystemElementResource", enumOption.ToString());
	}
}