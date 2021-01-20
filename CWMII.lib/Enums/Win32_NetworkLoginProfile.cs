namespace CWMII.lib.Enums {
	public enum Win32_NetworkLoginProfile {
		Caption,
		Description,
		SettingID,
		AccountExpires,
		AuthorizationFlags,
		BadPasswordCount,
		CodePage,
		Comment,
		CountryCode,
		Flags,
		FullName,
		HomeDirectory,
		HomeDirectoryDrive,
		LastLogoff,
		LastLogon,
		LogonHours,
		LogonServer,
		MaximumStorage,
		Name,
		NumberOfLogons,
		Parameters,
		PasswordAge,
		PasswordExpires,
		PrimaryGroupId,
		Privileges,
		Profile,
		ScriptPath,
		UnitsPerWeek,
		UserComment,
		UserId,
		UserType,
		Workstations
	}

	public static class Win32_NetworkLoginProfileExtension {
		public static string GetWMIValue(this Win32_NetworkLoginProfile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkLoginProfile", enumOption.ToString());
	}
}