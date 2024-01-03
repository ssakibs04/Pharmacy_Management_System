using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Serivces;

namespace App_layer.Controllers
{
	public class StockController : ApiController
	{
		[HttpGet]
		[Route("api/stock/all")]
		public HttpResponseMessage GetStocks()
		{
			try
			{
				var data = StockService.Get();
				return Request.CreateResponse(HttpStatusCode.OK, data);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpGet]
		[Route("api/stock/{id}")]
		public HttpResponseMessage GetStock(int id)
		{
			try
			{
				var data = StockService.Get(id);
				return Request.CreateResponse(HttpStatusCode.OK, data);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpPost]
		[Route("api/stock/add")]
		public HttpResponseMessage Add(StockDTO stock)
		{
			try
			{
				var res = StockService.Create(stock);
				return Request.CreateResponse(HttpStatusCode.OK, res);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpPatch]
		[Route("api/stock/edit/{id}")]
		public IHttpActionResult Update([FromBody] StockDTO stock)
		{
			try
			{
				var isUpdated = StockService.Update(stock);
				return ResponseMessage(isUpdated
					? Request.CreateResponse(HttpStatusCode.OK)
					: Request.CreateResponse(HttpStatusCode.BadRequest));
			}
			catch (Exception e)
			{
				if (!ModelState.IsValid) return BadRequest(ModelState);
				return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, e.Message));
			}
		}

		[HttpDelete]
		[Route("api/stock/delete/{id}")]
		public IHttpActionResult Delete(int id)
		{
			try
			{
				var isDeleted = StockService.Delete(id);
				return ResponseMessage(isDeleted
					? Request.CreateResponse(HttpStatusCode.OK)
					: Request.CreateResponse(HttpStatusCode.BadRequest));
			}
			catch (Exception e)
			{
				return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, e.Message));
			}
		}
	}
}
