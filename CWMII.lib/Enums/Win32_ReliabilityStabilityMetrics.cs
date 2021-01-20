namespace CWMII.lib.Enums {
	public enum Win32_ReliabilityStabilityMetrics {
		EndMeasurementDate,
		RelID,
		StartMeasurementDate,
		SystemStabilityIndex,
		TimeGenerated
	}

	public static class Win32_ReliabilityStabilityMetricsExtension {
		public static string GetWMIValue(this Win32_ReliabilityStabilityMetrics enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ReliabilityStabilityMetrics", enumOption.ToString());
	}
}