namespace CWMII.lib.Enums {
	public enum Win32_SystemLoadOrderGroups {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemLoadOrderGroupsExtension {
		public static string GetWMIValue(this Win32_SystemLoadOrderGroups enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemLoadOrderGroups", enumOption.ToString());
	}
}