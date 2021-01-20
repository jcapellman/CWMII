namespace CWMII.lib.Enums {
	public enum Win32_VolumeQuota {
		Element,
		Setting
	}

	public static class Win32_VolumeQuotaExtension {
		public static string GetWMIValue(this Win32_VolumeQuota enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_VolumeQuota", enumOption.ToString());
	}
}