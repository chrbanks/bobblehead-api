namespace BobbleheadApi.Controllers
{
    using System.Collections.Generic;
    
    using BobbleheadApi.Models;
    using BobbleheadApi.Repositories;
    
    using Microsoft.AspNet.Mvc;
    
    [RouteAttribute("api/[controller]")]
    public class BobbleheadsController : Controller
    {
        private readonly IBobbleheadRepository repository;
        
        public BobbleheadsController(IBobbleheadRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<Bobblehead> Get()
        {
            return this.repository.GetAll();
        }
        
        [HttpGetAttribute("{id}")]
        public Bobblehead Get(long id)
        {
            return this.repository.Get(id);
        }
        
        [HttpPost]
        public Bobblehead Post([FromBody]Bobblehead bobblehead)
        {
            return this.repository.Post(bobblehead);
        }
        
        [HttpPut("{id}")]
        public Bobblehead Put(long id, [FromBody]Bobblehead bobblehead)
        {
            return this.repository.Put(id, bobblehead);
        }
        
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            this.repository.Delete(id);
        }
    }
}