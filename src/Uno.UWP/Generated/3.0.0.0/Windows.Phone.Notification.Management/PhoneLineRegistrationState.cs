#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.Notification.Management
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum PhoneLineRegistrationState 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		Disconnected,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		Home,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		Roaming,
		#endif
	}
	#endif
}
