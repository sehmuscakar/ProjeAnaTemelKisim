using Core.Utilities;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface ITanıtımService
    {
        IDataResult<IList<Tanıtım>> GetList();

        IResult Add(Tanıtım tanıtım);

        IResult Update(Tanıtım tanıtım);//tanıtım:entity

        IResult Remove(Tanıtım tanıtım);

        IDataResult<Tanıtım> GetById(int Id);//günceleme id için o idyi getirmek için
    }
}
