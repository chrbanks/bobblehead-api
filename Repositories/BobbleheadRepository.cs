using System.Collections.Generic;
using System.Linq;
using BobbleheadApi.Models;
using Microsoft.Extensions.Logging;

namespace BobbleheadApi.Repositories
{
    public class BobbleheadRepository : IBobbleheadRepository
    {
        private readonly BobbleheadContext context;
        private readonly ILogger logger;
        
        public BobbleheadRepository(BobbleheadContext context, ILoggerFactory loggerFactory)
        {
            this.context = context;
            this.logger = loggerFactory.CreateLogger("IBobbleheadRepository");
        }
        public void Delete(long id)
        {
            var deletedRecord = this.context.Bobbleheads.First(x => x.Id == id);
            this.context.Bobbleheads.Remove(deletedRecord);
            this.context.SaveChanges();
            this.logger.LogInformation("Deleted bobblehead - Id: " + id);
        }

        public Bobblehead Get(long id)
        {
            this.logger.LogInformation("Getting bobblehead. Id: " + id);
            return this.context.Bobbleheads.First(x => x.Id == id);
        }

        public List<Bobblehead> GetAll()
        {
            this.logger.LogInformation("Getting all bobbleheads");
            return this.context.Bobbleheads.ToList();
        }

        public Bobblehead Post(Bobblehead bobblehead)
        {
            var addedRecord = this.context.Bobbleheads.Add(bobblehead);
            this.context.SaveChanges();
            this.logger.LogInformation("Added new bobblehead: " + bobblehead.Type);
            return addedRecord.Entity;
        }

        public Bobblehead Put(long id, Bobblehead bobblehead)
        {
            var updatedRecord = this.context.Bobbleheads.Update(bobblehead);
            this.context.SaveChanges();
            this.logger.LogInformation("Updated bobblehead - Id: " + id);
            return updatedRecord.Entity;
        }
    }
}