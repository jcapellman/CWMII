namespace CWMII.lib.Enums {
	public enum Win32_LoadOrderGroupServiceMembers {
		GroupComponent,
		PartComponent
	}

	public static class Win32_LoadOrderGroupServiceMembersExtension {
		public static string GetWMIValue(this Win32_LoadOrderGroupServiceMembers enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LoadOrderGroupServiceMembers", enumOption.ToString());
	}
}