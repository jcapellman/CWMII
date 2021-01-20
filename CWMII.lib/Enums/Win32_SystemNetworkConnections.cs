namespace CWMII.lib.Enums {
	public enum Win32_SystemNetworkConnections {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemNetworkConnectionsExtension {
		public static string GetWMIValue(this Win32_SystemNetworkConnections enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemNetworkConnections", enumOption.ToString());
	}
}