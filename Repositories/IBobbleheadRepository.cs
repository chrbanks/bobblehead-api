using System.Collections.Generic;
using BobbleheadApi.Models;

namespace BobbleheadApi.Repositories
{
    public interface IBobbleheadRepository
    {
        List<Bobblehead> GetAll();
        Bobblehead Get(long id);
        Bobblehead Post(Bobblehead bobblehead);
        Bobblehead Put(long id, Bobblehead bobblehead);
        void Delete(long id);
    }
}