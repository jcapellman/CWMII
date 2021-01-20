namespace CWMII.lib.Enums {
	public enum Win32_COMApplicationClasses {
		GroupComponent,
		PartComponent
	}

	public static class Win32_COMApplicationClassesExtension {
		public static string GetWMIValue(this Win32_COMApplicationClasses enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_COMApplicationClasses", enumOption.ToString());
	}
}