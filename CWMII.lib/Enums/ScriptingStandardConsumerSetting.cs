namespace CWMII.lib.Enums {
	public enum ScriptingStandardConsumerSetting {
		Caption,
		Description,
		SettingID,
		MaximumScripts,
		Timeout
	}

	public static class ScriptingStandardConsumerSettingExtension {
		public static string GetWMIValue(this ScriptingStandardConsumerSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM ScriptingStandardConsumerSetting", enumOption.ToString());
	}
}