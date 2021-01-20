namespace CWMII.lib.Enums {
	public enum SoftwareLicensingService {
		ClientMachineID,
		DiscoveredKeyManagementServiceMachineIpAddress,
		DiscoveredKeyManagementServiceMachineName,
		DiscoveredKeyManagementServiceMachinePort,
		IsKeyManagementServiceMachine,
		KeyManagementServiceCurrentCount,
		KeyManagementServiceDnsPublishing,
		KeyManagementServiceFailedRequests,
		KeyManagementServiceHostCaching,
		KeyManagementServiceLicensedRequests,
		KeyManagementServiceListeningPort,
		KeyManagementServiceLookupDomain,
		KeyManagementServiceLowPriority,
		KeyManagementServiceMachine,
		KeyManagementServiceNonGenuineGraceRequests,
		KeyManagementServiceNotificationRequests,
		KeyManagementServiceOOBGraceRequests,
		KeyManagementServiceOOTGraceRequests,
		KeyManagementServicePort,
		KeyManagementServiceProductKeyID,
		KeyManagementServiceTotalRequests,
		KeyManagementServiceUnlicensedRequests,
		OA2xBiosMarkerMinorVersion,
		OA2xBiosMarkerStatus,
		OA3xOriginalProductKey,
		OA3xOriginalProductKeyDescription,
		OA3xOriginalProductKeyPkPn,
		PolicyCacheRefreshRequired,
		RemainingWindowsReArmCount,
		RequiredClientCount,
		TokenActivationAdditionalInfo,
		TokenActivationCertificateThumbprint,
		TokenActivationGrantNumber,
		TokenActivationILID,
		TokenActivationILVID,
		Version,
		VLActivationInterval,
		VLRenewalInterval
	}

	public static class SoftwareLicensingServiceExtension {
		public static string GetWMIValue(this SoftwareLicensingService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM SoftwareLicensingService", enumOption.ToString());
	}
}