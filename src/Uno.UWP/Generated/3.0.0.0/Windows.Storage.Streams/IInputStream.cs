#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInputStream : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, uint> ReadAsync( global::Windows.Storage.Streams.IBuffer buffer,  uint count,  global::Windows.Storage.Streams.InputStreamOptions options);
		#endif
	}
}