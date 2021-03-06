namespace CWMII.lib.Enums {
	public enum Win32_OperatingSystem {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		CSCreationClassName,
		CSName,
		CurrentTimeZone,
		Distributed,
		FreePhysicalMemory,
		FreeSpaceInPagingFiles,
		FreeVirtualMemory,
		LastBootUpTime,
		LocalDateTime,
		MaxNumberOfProcesses,
		MaxProcessMemorySize,
		NumberOfLicensedUsers,
		NumberOfProcesses,
		NumberOfUsers,
		OSType,
		OtherTypeDescription,
		SizeStoredInPagingFiles,
		TotalSwapSpaceSize,
		TotalVirtualMemorySize,
		TotalVisibleMemorySize,
		Version,
		BootDevice,
		BuildNumber,
		BuildType,
		CodeSet,
		CountryCode,
		CSDVersion,
		DataExecutionPrevention_32BitApplications,
		DataExecutionPrevention_Available,
		DataExecutionPrevention_Drivers,
		DataExecutionPrevention_SupportPolicy,
		Debug,
		EncryptionLevel,
		ForegroundApplicationBoost,
		LargeSystemCache,
		Locale,
		Manufacturer,
		MUILanguages,
		OperatingSystemSKU,
		Organization,
		OSArchitecture,
		OSLanguage,
		OSProductSuite,
		PAEEnabled,
		PlusProductID,
		PlusVersionNumber,
		PortableOperatingSystem,
		Primary,
		ProductType,
		RegisteredUser,
		SerialNumber,
		ServicePackMajorVersion,
		ServicePackMinorVersion,
		SuiteMask,
		SystemDevice,
		SystemDirectory,
		SystemDrive,
		WindowsDirectory
	}

	public static class Win32_OperatingSystemExtension {
		public static string GetWMIValue(this Win32_OperatingSystem enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OperatingSystem", enumOption.ToString());
	}
}