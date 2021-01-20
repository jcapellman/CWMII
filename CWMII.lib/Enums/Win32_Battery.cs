namespace CWMII.lib.Enums {
	public enum Win32_Battery {
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

	public static class Win32_BatteryExtension {
		public static string GetWMIValue(this Win32_Battery enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Battery", enumOption.ToString());
	}
}