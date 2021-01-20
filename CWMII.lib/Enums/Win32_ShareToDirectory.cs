namespace CWMII.lib.Enums {
	public enum Win32_ShareToDirectory {
		Share,
		SharedElement
	}

	public static class Win32_ShareToDirectoryExtension {
		public static string GetWMIValue(this Win32_ShareToDirectory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ShareToDirectory", enumOption.ToString());
	}
}