using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public partial class MediaPlaybackItem : IMediaPlaybackSource
	{
		public MediaSource Source;

		public MediaPlaybackItem(MediaSource source)
		{
			Source = source;
		}
	}
}
