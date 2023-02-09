using Core.DataAccess;
using Repository.Entities;
using Repository.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
   public interface INotlarRepository : IEntityRepository<Notlar>
    {
    }
}
