using Core.Utilities;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class TanıtımService : ITanıtımService
    {

        ITanıtımRepository _itanıtımRepository;

        public TanıtımService(ITanıtımRepository itanıtımRepository)
        {
            _itanıtımRepository = itanıtımRepository;
        }

        public IResult Add(Tanıtım tanıtım)
        {
            tanıtım.CreatedAt= DateTime.Now;
            _itanıtımRepository.Add(tanıtım);
            var result = new SuccessResult("Kayıt Başarılı bir şekilde eklendi");
            return result;

        }

        public IDataResult<Tanıtım> GetById(int Id)
        {
             return new SuccessDataResult<Tanıtım>(_itanıtımRepository.Get(p=>p.Id== Id));
           
        }

        public IDataResult<IList<Tanıtım>> GetList()
        {
            var data = _itanıtımRepository.GetActiveList();
            var result = new SuccessDataResult<IList<Tanıtım>>(data, "Başarılı");
            return result;
        }

        public IResult Remove(Tanıtım tanıtım)
        {
            _itanıtımRepository.Delete(tanıtım);
            return new SuccessResult("Kayıt başarılı bir şekilde silindi");
        }

        public IResult Update(Tanıtım tanıtım)
        {
            tanıtım.UpdatedAt = DateTime.Now;
            _itanıtımRepository.Update(tanıtım);
            return new SuccessResult("Kayıt başarılı bir şekilde güncellendi");
        }
    }
}
