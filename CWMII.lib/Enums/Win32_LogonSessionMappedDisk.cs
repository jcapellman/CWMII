namespace CWMII.lib.Enums {
	public enum Win32_LogonSessionMappedDisk {
		Antecedent,
		Dependent
	}

	public static class Win32_LogonSessionMappedDiskExtension {
		public static string GetWMIValue(this Win32_LogonSessionMappedDisk enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogonSessionMappedDisk", enumOption.ToString());
	}
}