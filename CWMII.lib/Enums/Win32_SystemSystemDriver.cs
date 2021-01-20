namespace CWMII.lib.Enums {
	public enum Win32_SystemSystemDriver {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemSystemDriverExtension {
		public static string GetWMIValue(this Win32_SystemSystemDriver enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemSystemDriver", enumOption.ToString());
	}
}