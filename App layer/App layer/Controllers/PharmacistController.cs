using BLL.DTOs;
using BLL.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App_layer.Controllers
{
    public class PharmacistController : ApiController
    {
        [HttpGet]
        [Route("api/pharmacist/all")]
        public HttpResponseMessage GetPhamacists()
        {
            try
            {
                var data = PharmacistService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/pharmacist/{id}")]
        public HttpResponseMessage GetPharmacist(int id)
        {
            try
            {
                var data = PharmacistService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/pharmacist/add")]
        public HttpResponseMessage Add(PharmacistDTO pharmacist)
        {
            try
            {
                var res = PharmacistService.Create(pharmacist);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPatch]
        [Route("api/pharmacist/editprofile")]
        public IHttpActionResult Update([FromBody] PharmacistDTO pharmacist)
        {
            try
            {
                var isUpdated = PharmacistService.Update(pharmacist);
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
        [Route("api/pharmacist/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var isDeleted = PharmacistService.Delete(id);
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
