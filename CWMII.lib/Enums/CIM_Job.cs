namespace CWMII.lib.Enums {
	public enum CIM_Job {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		ElapsedTime,
		JobStatus,
		Notify,
		Owner,
		Priority,
		StartTime,
		TimeSubmitted,
		UntilTime,
		Color,
		DataType,
		Document,
		DriverName,
		HostPrintQueue,
		JobId,
		PagesPrinted,
		PaperLength,
		PaperSize,
		PaperWidth,
		Parameters,
		PrintProcessor,
		Size,
		SizeHigh,
		StatusMask,
		TotalPages
	}

	public static class CIM_JobExtension {
		public static string GetWMIValue(this CIM_Job enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Job", enumOption.ToString());
	}
}