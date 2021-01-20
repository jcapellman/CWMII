namespace CWMII.lib.Enums {
	public enum Win32_MountPoint {
		Directory,
		Volume
	}

	public static class Win32_MountPointExtension {
		public static string GetWMIValue(this Win32_MountPoint enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MountPoint", enumOption.ToString());
	}
}