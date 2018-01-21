using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        // POST: api/Home
        [HttpPost]
        public string Post([FromBody] postModelData obj)
        {
            string myObj = "Success";
            return myObj.ToString();
        }

        // GET: api/Home/5
        [HttpGet]
        public string Get(int id)
        {
            string myObj = "[{\"Status\":\"Team Work Rocks\"},[{\"ProjectA\":\"1\"},{\"ProjectB\":\"2\"},{\"ProjectC\":\"3\"}]]";
            return myObj.ToString();            
        }
                
        // PUT: api/Home/1
        public void Put(int id, [FromBody] putModelData putModelObj)
        {
            string myObj = putModelObj.DataVar1 + " " + putModelObj.DataVar2;
        }

        // DELETE: api/Home/2
        public void Delete(int id)
        {
            //Delete Logic
        }
    }
}

public class postModelData
{
    public string FstVarValue;
    public string SndVarValue;    
}

public class putModelData
{
    public string DataVar1;
    public string DataVar2;
}
