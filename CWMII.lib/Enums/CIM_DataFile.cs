namespace CWMII.lib.Enums {
	public enum CIM_DataFile {
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
		Version
	}

	public static class CIM_DataFileExtension {
		public static string GetWMIValue(this CIM_DataFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DataFile", enumOption.ToString());
	}
}