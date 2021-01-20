namespace CWMII.lib.Enums {
	public enum Win32_NetworkConnection {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AccessMask,
		Comment,
		ConnectionState,
		ConnectionType,
		DisplayType,
		LocalName,
		Persistent,
		ProviderName,
		RemoteName,
		RemotePath,
		ResourceType,
		UserName
	}

	public static class Win32_NetworkConnectionExtension {
		public static string GetWMIValue(this Win32_NetworkConnection enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkConnection", enumOption.ToString());
	}
}