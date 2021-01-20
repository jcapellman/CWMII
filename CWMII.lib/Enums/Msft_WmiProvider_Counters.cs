namespace CWMII.lib.Enums {
	public enum Msft_WmiProvider_Counters {
		ProviderOperation_AccessCheck,
		ProviderOperation_CancelQuery,
		ProviderOperation_CreateClassEnumAsync,
		ProviderOperation_CreateInstanceEnumAsync,
		ProviderOperation_CreateRefreshableEnum,
		ProviderOperation_CreateRefreshableObject,
		ProviderOperation_CreateRefresher,
		ProviderOperation_DeleteClassAsync,
		ProviderOperation_DeleteInstanceAsync,
		ProviderOperation_ExecMethodAsync,
		ProviderOperation_ExecQueryAsync,
		ProviderOperation_FindConsumer,
		ProviderOperation_GetObjectAsync,
		ProviderOperation_GetObjects,
		ProviderOperation_GetProperty,
		ProviderOperation_NewQuery,
		ProviderOperation_ProvideEvents,
		ProviderOperation_PutClassAsync,
		ProviderOperation_PutInstanceAsync,
		ProviderOperation_PutProperty,
		ProviderOperation_QueryInstances,
		ProviderOperation_SetRegistrationObject,
		ProviderOperation_StopRefreshing,
		ProviderOperation_ValidateSubscription
	}

	public static class Msft_WmiProvider_CountersExtension {
		public static string GetWMIValue(this Msft_WmiProvider_Counters enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Msft_WmiProvider_Counters", enumOption.ToString());
	}
}