namespace CWMII.lib.Enums {
	public enum Win32_SystemPartitions {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemPartitionsExtension {
		public static string GetWMIValue(this Win32_SystemPartitions enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemPartitions", enumOption.ToString());
	}
}