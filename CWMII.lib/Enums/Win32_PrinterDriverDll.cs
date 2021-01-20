namespace CWMII.lib.Enums {
	public enum Win32_PrinterDriverDll {
		Antecedent,
		Dependent
	}

	public static class Win32_PrinterDriverDllExtension {
		public static string GetWMIValue(this Win32_PrinterDriverDll enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PrinterDriverDll", enumOption.ToString());
	}
}