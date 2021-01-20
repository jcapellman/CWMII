namespace CWMII.lib.Enums {
	public enum Win32_UserAccount {
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

	public static class Win32_UserAccountExtension {
		public static string GetWMIValue(this Win32_UserAccount enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_UserAccount", enumOption.ToString());
	}
}