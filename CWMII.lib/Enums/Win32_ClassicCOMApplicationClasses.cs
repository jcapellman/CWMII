namespace CWMII.lib.Enums {
	public enum Win32_ClassicCOMApplicationClasses {
		GroupComponent,
		PartComponent
	}

	public static class Win32_ClassicCOMApplicationClassesExtension {
		public static string GetWMIValue(this Win32_ClassicCOMApplicationClasses enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ClassicCOMApplicationClasses", enumOption.ToString());
	}
}