namespace CWMII.lib.Enums {
	public enum CIM_Battery {
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
		BatteryStatus,
		Chemistry,
		DesignCapacity,
		DesignVoltage,
		EstimatedChargeRemaining,
		EstimatedRunTime,
		ExpectedLife,
		FullChargeCapacity,
		MaxRechargeTime,
		SmartBatteryVersion,
		TimeOnBattery,
		TimeToFullCharge,
		BatteryRechargeTime,
		ExpectedBatteryLife
	}

	public static class CIM_BatteryExtension {
		public static string GetWMIValue(this CIM_Battery enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Battery", enumOption.ToString());
	}
}