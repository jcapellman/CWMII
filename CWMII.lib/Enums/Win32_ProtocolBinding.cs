namespace CWMII.lib.Enums {
	public enum Win32_ProtocolBinding {
		Antecedent,
		Dependent,
		Device
	}

	public static class Win32_ProtocolBindingExtension {
		public static string GetWMIValue(this Win32_ProtocolBinding enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProtocolBinding", enumOption.ToString());
	}
}