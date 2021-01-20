namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		HealthCritical,
		HealthOk
	}

	public static class Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummaryExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary", enumOption.ToString());
	}
}