using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using BLL.Serivces;
using BLL.DTOs;

namespace App_layer.Controllers
{
    public class MedicineController : ApiController
    {
        [HttpPost]
        [Route("api/medicine/add")]
        public HttpResponseMessage Add(MedicineDTO medicine)
        {
            try
            {
                var res = MedicineService.Create(medicine);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/medicine/all")]
        public HttpResponseMessage GetMedicine()
        {
            try
            {
                var data = MedicineService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/medicine/{id}")]
        public HttpResponseMessage GetMedicine(int id)
        {
            try
            {
                var data = MedicineService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPatch]
        [Route("api/medicine/editprofile")]
        public IHttpActionResult Update([FromBody] MedicineDTO medicine)
        {
            try
            {
                var isUpdated = MedicineService.Update(medicine);
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
        [Route("api/medicine/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var isDeleted = MedicineService.Delete(id);
                return ResponseMessage(isDeleted
                    ? Request.CreateResponse(HttpStatusCode.OK)
                    : Request.CreateResponse(HttpStatusCode.BadRequest));
            }
            catch (Exception e)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, e.Message));
            }
        }
        [HttpPost]
        [Route("api/cart/add")]
        public HttpResponseMessage AddCart(CartDTO cart)
        {
            try
            {
                var res = CartService.Create(cart);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/cart/{id}")]
        public HttpResponseMessage Cart(int id)
        {
            try
            {
                var res = CartService.GetCart(id);
                return Request.CreateResponse(new { cart = res });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/cart/delete/{id}")]
        public HttpResponseMessage DeleteCart(int id)
        {
            try
            {
                var res = CartService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        


    }
}