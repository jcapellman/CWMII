namespace CWMII.lib.Enums {
	public enum CIM_FileSpecification {
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

	public static class CIM_FileSpecificationExtension {
		public static string GetWMIValue(this CIM_FileSpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_FileSpecification", enumOption.ToString());
	}
}