namespace CWMII.lib.Enums {
	public enum Win32_LogicalDiskRootDirectory {
		GroupComponent,
		PartComponent
	}

	public static class Win32_LogicalDiskRootDirectoryExtension {
		public static string GetWMIValue(this Win32_LogicalDiskRootDirectory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalDiskRootDirectory", enumOption.ToString());
	}
}