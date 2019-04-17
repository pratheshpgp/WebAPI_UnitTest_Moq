using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace UnitTest.Controllers
{
    public class MoqController : ApiController
    {
        private readonly IGetDataRepository _data;

        public MoqController(IGetDataRepository data)
        {
            _data = data;
        }

        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }
    }
}
