namespace CWMII.lib.Enums {
	public enum CIM_DMA {
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

	public static class CIM_DMAExtension {
		public static string GetWMIValue(this CIM_DMA enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DMA", enumOption.ToString());
	}
}