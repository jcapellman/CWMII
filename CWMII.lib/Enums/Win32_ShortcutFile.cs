namespace CWMII.lib.Enums {
	public enum Win32_ShortcutFile {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AccessMask,
		Archive,
		Compressed,
		CompressionMethod,
		CreationClassName,
		CreationDate,
		CSCreationClassName,
		CSName,
		Drive,
		EightDotThreeFileName,
		Encrypted,
		EncryptionMethod,
		Extension,
		FileName,
		FileSize,
		FileType,
		FSCreationClassName,
		FSName,
		Hidden,
		InUseCount,
		LastAccessed,
		LastModified,
		Path,
		Readable,
		System,
		Writeable,
		Manufacturer,
		Version,
		Target
	}

	public static class Win32_ShortcutFileExtension {
		public static string GetWMIValue(this Win32_ShortcutFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ShortcutFile", enumOption.ToString());
	}
}