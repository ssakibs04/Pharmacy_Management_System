using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace App_layer.Controllers
{
	public class DiscountController : ApiController
	{
		[HttpGet]
		[Route("api/discount/all")]
		public IHttpActionResult GetDiscounts()
		{
			try
			{
				var data = DiscountService.Get();
				return Ok(data);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpGet]
		[Route("api/discount/{id}")]
		public IHttpActionResult GetDiscount(int id)
		{
			try
			{
				var data = DiscountService.Get(id);
				return Ok(data);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		[Route("api/discount/add")]
		public IHttpActionResult Add(DiscountDTO discount)
		{
			try
			{
				var res = DiscountService.Create(discount);
				return Ok(res); // Assuming the service returns the created object
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPatch]
		[Route("api/discount/edit")]
		public IHttpActionResult Update([FromBody] DiscountDTO discount)
		{
			try
			{
				var isUpdated = DiscountService.Update(discount);
				return isUpdated ? (IHttpActionResult)Ok() : BadRequest("Update failed");
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpDelete]
		[Route("api/discount/delete/{id}")]
		public IHttpActionResult Delete(int id)
		{
			try
			{
				var isDeleted = DiscountService.Delete(id);
				return isDeleted ? (IHttpActionResult)Ok() : BadRequest("Deletion failed");
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
