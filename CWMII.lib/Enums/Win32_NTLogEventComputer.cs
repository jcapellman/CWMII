namespace CWMII.lib.Enums {
	public enum Win32_NTLogEventComputer {
		Computer,
		Record
	}

	public static class Win32_NTLogEventComputerExtension {
		public static string GetWMIValue(this Win32_NTLogEventComputer enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTLogEventComputer", enumOption.ToString());
	}
}