using BLL.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace App_layer.Controllers
{
    public class SaleController : ApiController
    {
        [HttpGet]
        [Route("api/sale/all")]
        public HttpResponseMessage GetSale()
        {
            try
            {
                var data = SaleService.Get;
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}