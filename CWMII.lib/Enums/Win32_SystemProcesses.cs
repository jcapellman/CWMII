namespace CWMII.lib.Enums {
	public enum Win32_SystemProcesses {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemProcessesExtension {
		public static string GetWMIValue(this Win32_SystemProcesses enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemProcesses", enumOption.ToString());
	}
}