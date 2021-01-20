namespace CWMII.lib.Enums {
	public enum Win32_IP4RouteTable {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Age,
		Destination,
		Information,
		InterfaceIndex,
		Mask,
		Metric1,
		Metric2,
		Metric3,
		Metric4,
		Metric5,
		NextHop,
		Protocol,
		Type
	}

	public static class Win32_IP4RouteTableExtension {
		public static string GetWMIValue(this Win32_IP4RouteTable enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_IP4RouteTable", enumOption.ToString());
	}
}