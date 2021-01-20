namespace CWMII.lib.Enums {
	public enum Win32_DMAChannel {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AddressSize,
		Availability,
		BurstMode,
		ByteMode,
		ChannelTiming,
		CreationClassName,
		CSCreationClassName,
		CSName,
		DMAChannel,
		MaxTransferSize,
		TransferWidths,
		TypeCTiming,
		WordMode,
		Port
	}

	public static class Win32_DMAChannelExtension {
		public static string GetWMIValue(this Win32_DMAChannel enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DMAChannel", enumOption.ToString());
	}
}