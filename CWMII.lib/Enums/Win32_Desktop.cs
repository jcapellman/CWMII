namespace CWMII.lib.Enums {
	public enum Win32_Desktop {
		Caption,
		Description,
		SettingID,
		BorderWidth,
		CoolSwitch,
		CursorBlinkRate,
		DragFullWindows,
		GridGranularity,
		IconSpacing,
		IconTitleFaceName,
		IconTitleSize,
		IconTitleWrap,
		Name,
		Pattern,
		ScreenSaverActive,
		ScreenSaverExecutable,
		ScreenSaverSecure,
		ScreenSaverTimeout,
		Wallpaper,
		WallpaperStretched,
		WallpaperTiled
	}

	public static class Win32_DesktopExtension {
		public static string GetWMIValue(this Win32_Desktop enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Desktop", enumOption.ToString());
	}
}