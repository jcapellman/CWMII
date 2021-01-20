namespace CWMII.lib.Enums {
	public enum Win32_CodecFile {
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
		Group
	}

	public static class Win32_CodecFileExtension {
		public static string GetWMIValue(this Win32_CodecFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CodecFile", enumOption.ToString());
	}
}