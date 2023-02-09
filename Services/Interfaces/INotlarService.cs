using Core.Utilities;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface INotlarService
    {
        IDataResult<IList<Notlar>> GetList();

        IResult Add(Notlar notlar);

        IResult Update(Notlar notlar);//tanıtım:entity

        IResult Remove(Notlar notlar);

        IDataResult<Notlar> GetById(int Id);//günceleme id için o idyi getirmek için
                                         
       


    }
}
