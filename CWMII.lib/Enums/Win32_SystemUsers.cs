namespace CWMII.lib.Enums {
	public enum Win32_SystemUsers {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemUsersExtension {
		public static string GetWMIValue(this Win32_SystemUsers enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemUsers", enumOption.ToString());
	}
}