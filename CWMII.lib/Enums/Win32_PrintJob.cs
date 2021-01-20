namespace CWMII.lib.Enums {
	public enum Win32_PrintJob {
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

	public static class Win32_PrintJobExtension {
		public static string GetWMIValue(this Win32_PrintJob enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PrintJob", enumOption.ToString());
	}
}