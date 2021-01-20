namespace CWMII.lib.Enums {
	public enum Win32_ProgramGroupContents {
		GroupComponent,
		PartComponent
	}

	public static class Win32_ProgramGroupContentsExtension {
		public static string GetWMIValue(this Win32_ProgramGroupContents enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProgramGroupContents", enumOption.ToString());
	}
}