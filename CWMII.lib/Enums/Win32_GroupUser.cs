namespace CWMII.lib.Enums {
	public enum Win32_GroupUser {
		GroupComponent,
		PartComponent
	}

	public static class Win32_GroupUserExtension {
		public static string GetWMIValue(this Win32_GroupUser enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_GroupUser", enumOption.ToString());
	}
}