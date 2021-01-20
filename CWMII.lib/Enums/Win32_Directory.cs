namespace CWMII.lib.Enums {
	public enum Win32_Directory {
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
		Writeable
	}

	public static class Win32_DirectoryExtension {
		public static string GetWMIValue(this Win32_Directory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Directory", enumOption.ToString());
	}
}