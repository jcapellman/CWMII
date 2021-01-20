namespace CWMII.lib.Enums {
	public enum CIM_MediaPresent {
		Antecedent,
		Dependent
	}

	public static class CIM_MediaPresentExtension {
		public static string GetWMIValue(this CIM_MediaPresent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_MediaPresent", enumOption.ToString());
	}
}