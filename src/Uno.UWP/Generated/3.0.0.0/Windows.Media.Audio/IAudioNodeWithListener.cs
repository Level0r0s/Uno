#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAudioNodeWithListener : global::System.IDisposable,global::Windows.Media.Audio.IAudioNode
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		global::Windows.Media.Audio.AudioNodeListener Listener
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.IAudioNodeWithListener.Listener.set
		// Forced skipping of method Windows.Media.Audio.IAudioNodeWithListener.Listener.get
	}
}
