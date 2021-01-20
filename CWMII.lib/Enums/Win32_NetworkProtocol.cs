namespace CWMII.lib.Enums {
	public enum Win32_NetworkProtocol {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		ConnectionlessService,
		GuaranteesDelivery,
		GuaranteesSequencing,
		MaximumAddressSize,
		MaximumMessageSize,
		MessageOriented,
		MinimumAddressSize,
		PseudoStreamOriented,
		SupportsBroadcasting,
		SupportsConnectData,
		SupportsDisconnectData,
		SupportsEncryption,
		SupportsExpeditedData,
		SupportsFragmentation,
		SupportsGracefulClosing,
		SupportsGuaranteedBandwidth,
		SupportsMulticasting,
		SupportsQualityofService
	}

	public static class Win32_NetworkProtocolExtension {
		public static string GetWMIValue(this Win32_NetworkProtocol enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkProtocol", enumOption.ToString());
	}
}