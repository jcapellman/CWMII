namespace CWMII.lib.Enums {
	public enum CIM_NetworkAdapter {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Availability,
		ConfigManagerErrorCode,
		ConfigManagerUserConfig,
		CreationClassName,
		DeviceID,
		ErrorCleared,
		ErrorDescription,
		LastErrorCode,
		PNPDeviceID,
		PowerManagementCapabilities,
		PowerManagementSupported,
		StatusInfo,
		SystemCreationClassName,
		SystemName,
		AutoSense,
		MaxSpeed,
		NetworkAddresses,
		PermanentAddress,
		Speed,
		AdapterType,
		AdapterTypeId,
		GUID,
		Index,
		Installed,
		InterfaceIndex,
		MACAddress,
		Manufacturer,
		MaxNumberControlled,
		NetConnectionID,
		NetConnectionStatus,
		NetEnabled,
		PhysicalAdapter,
		ProductName,
		ServiceName,
		TimeOfLastReset
	}

	public static class CIM_NetworkAdapterExtension {
		public static string GetWMIValue(this CIM_NetworkAdapter enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_NetworkAdapter", enumOption.ToString());
	}
}