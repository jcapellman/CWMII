namespace CWMII.lib.Enums {
	public enum Win32_FileSpecification {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		CheckSum,
		CRC1,
		CRC2,
		CreateTimeStamp,
		FileSize,
		MD5Checksum,
		Attributes,
		FileID,
		Language,
		Sequence
	}

	public static class Win32_FileSpecificationExtension {
		public static string GetWMIValue(this Win32_FileSpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_FileSpecification", enumOption.ToString());
	}
}