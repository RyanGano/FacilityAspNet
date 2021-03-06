// DO NOT EDIT: generated by fsdgenaspnet
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Facility.Core;

#pragma warning disable 1591 // missing XML comment

namespace Facility.ExampleApi.Controllers
{
	[System.CodeDom.Compiler.GeneratedCode("fsdgenaspnet", "")]
	public partial class ExampleApiController
	{
		[HttpGet, Route("widgets")]
		public Task<HttpResponseMessage> GetWidgets(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetWidgetsAsync(httpRequest, cancellationToken);
		}

		[HttpPost, Route("widgets")]
		public Task<HttpResponseMessage> CreateWidget(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleCreateWidgetAsync(httpRequest, cancellationToken);
		}

		[HttpGet, Route("widgets/{id}")]
		public Task<HttpResponseMessage> GetWidget(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetWidgetAsync(httpRequest, cancellationToken);
		}

		[HttpDelete, Route("widgets/{id}")]
		public Task<HttpResponseMessage> DeleteWidget(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleDeleteWidgetAsync(httpRequest, cancellationToken);
		}

		[HttpPost, Route("widgets/{id}")]
		public Task<HttpResponseMessage> EditWidget(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleEditWidgetAsync(httpRequest, cancellationToken);
		}

		[HttpPost, Route("widgets/get")]
		public Task<HttpResponseMessage> GetWidgetBatch(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetWidgetBatchAsync(httpRequest, cancellationToken);
		}

		[Obsolete]
		[HttpGet, Route("widgets/{id}/weight")]
		public Task<HttpResponseMessage> GetWidgetWeight(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetWidgetWeightAsync(httpRequest, cancellationToken);
		}

		[HttpGet, Route("prefs/{key}")]
		public Task<HttpResponseMessage> GetPreference(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetPreferenceAsync(httpRequest, cancellationToken);
		}

		[HttpPut, Route("prefs/{key}")]
		public Task<HttpResponseMessage> SetPreference(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleSetPreferenceAsync(httpRequest, cancellationToken);
		}

		[HttpGet, Route("")]
		public Task<HttpResponseMessage> GetInfo(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleGetInfoAsync(httpRequest, cancellationToken);
		}

		[HttpPost, Route("notRestful")]
		public Task<HttpResponseMessage> NotRestful(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleNotRestfulAsync(httpRequest, cancellationToken);
		}

		[HttpPost, Route("kitchen")]
		public Task<HttpResponseMessage> Kitchen(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return GetServiceHttpHandler().TryHandleKitchenAsync(httpRequest, cancellationToken);
		}
	}
}
