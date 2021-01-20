namespace CWMII.lib.Enums {
	public enum Win32_ComClassEmulator {
		NewVersion,
		OldVersion
	}

	public static class Win32_ComClassEmulatorExtension {
		public static string GetWMIValue(this Win32_ComClassEmulator enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ComClassEmulator", enumOption.ToString());
	}
}