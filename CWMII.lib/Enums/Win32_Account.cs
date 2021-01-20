namespace CWMII.lib.Enums {
	public enum Win32_Account {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Domain,
		LocalAccount,
		SID,
		SIDType,
		AccountType,
		Disabled,
		FullName,
		Lockout,
		PasswordChangeable,
		PasswordExpires,
		PasswordRequired
	}

	public static class Win32_AccountExtension {
		public static string GetWMIValue(this Win32_Account enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Account", enumOption.ToString());
	}
}