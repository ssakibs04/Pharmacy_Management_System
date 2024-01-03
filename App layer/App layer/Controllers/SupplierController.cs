using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Serivces;

namespace App_layer.Controllers
{
	public class SupplierController : ApiController
	{
		[HttpGet]
		[Route("api/supplier/all")]
		public HttpResponseMessage GetSuppliers()
		{
			try
			{
				var data = SupplierService.Get();
				return Request.CreateResponse(HttpStatusCode.OK, data);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpGet]
		[Route("api/supplier/{id}")]
		public HttpResponseMessage GetSupplier(int id)
		{
			try
			{
				var data = SupplierService.Get(id);
				return Request.CreateResponse(HttpStatusCode.OK, data);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpPost]
		[Route("api/supplier/add")]
		public HttpResponseMessage Add(SupplierDTO supplier)
		{
			try
			{
				var res = SupplierService.Create(supplier);
				return Request.CreateResponse(HttpStatusCode.OK, res);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		[HttpPatch]
		[Route("api/supplier/editprofile")]
		public IHttpActionResult Update([FromBody] SupplierDTO supplier)
		{
			try
			{
				var isUpdated = SupplierService.Update(supplier);
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
		[Route("api/supplier/delete/{id}")]
		public IHttpActionResult Delete(int id)
		{
			try
			{
				var isDeleted = SupplierService.Delete(id);
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
