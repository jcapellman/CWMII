namespace CWMII.lib.Enums {
	public enum Win32_NTEventlogFile {
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
		LogfileName,
		MaxFileSize,
		NumberOfRecords,
		OverwriteOutDated,
		OverWritePolicy,
		Sources
	}

	public static class Win32_NTEventlogFileExtension {
		public static string GetWMIValue(this Win32_NTEventlogFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTEventlogFile", enumOption.ToString());
	}
}