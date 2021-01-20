namespace CWMII.lib.Enums {
	public enum Win32_SubDirectory {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SubDirectoryExtension {
		public static string GetWMIValue(this Win32_SubDirectory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SubDirectory", enumOption.ToString());
	}
}