namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfNet_Browser {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AnnouncementsDomainPersec,
		AnnouncementsServerPersec,
		AnnouncementsTotalPersec,
		DuplicateMasterAnnouncements,
		ElectionPacketsPersec,
		EnumerationsDomainPersec,
		EnumerationsOtherPersec,
		EnumerationsServerPersec,
		EnumerationsTotalPersec,
		IllegalDatagramsPersec,
		MailslotAllocationsFailed,
		MailslotOpensFailedPersec,
		MailslotReceivesFailed,
		MailslotWritesFailed,
		MailslotWritesPersec,
		MissedMailslotDatagrams,
		MissedServerAnnouncements,
		MissedServerListRequests,
		ServerAnnounceAllocationsFailedPersec,
		ServerListRequestsPersec
	}

	public static class Win32_PerfFormattedData_PerfNet_BrowserExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfNet_Browser enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfNet_Browser", enumOption.ToString());
	}
}