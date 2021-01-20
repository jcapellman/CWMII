namespace CWMII.lib.Enums {
	public enum Win32_WinSAT {
		CPUScore,
		D3DScore,
		DiskScore,
		GraphicsScore,
		MemoryScore,
		TimeTaken,
		WinSATAssessmentState,
		WinSPRLevel
	}

	public static class Win32_WinSATExtension {
		public static string GetWMIValue(this Win32_WinSAT enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_WinSAT", enumOption.ToString());
	}
}