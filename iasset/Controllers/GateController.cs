using Data;
using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iasset.Controllers
{
    public class GateController : ApiController
    {
        IGateManageService gateService;

        public GateController(IGateManageService service)
        {
            gateService = service;
        }

        [HttpGet]
        public ICollection<Gate> Test()
        {
            return gateService.GetGates();
        }
    }
}
