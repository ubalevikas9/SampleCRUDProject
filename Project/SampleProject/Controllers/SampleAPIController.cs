using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleProject.DAL;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleAPIController : ControllerBase
    {
        public SampleDBContext context;
        public SampleAPIController(SampleDBContext _dbcontext)
        {
            context = _dbcontext;
        }
        // GET: api/SampleAPI
        [HttpGet("getItems")]
        public List<ItemModel> Get()
        {
            var itemList = context.Items.ToList();
            return itemList;
        }

        // POST: api/SampleAPI
        [HttpPost]
        public void Post([FromBody] StateModel stateObj)
        {

            context.State.Add(stateObj);
            context.SaveChanges();
        }
        [HttpGet("getStates")]
        public List<StateModel> GetState()
        {
            var stateList = context.State.ToList();
            return stateList;
        }
      
    }
}
