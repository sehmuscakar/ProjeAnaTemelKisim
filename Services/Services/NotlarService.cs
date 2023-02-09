using Core.Utilities;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class NotlarService : INotlarService
    {
        INotlarRepository _inotlarRepository;

        public NotlarService(INotlarRepository inotlarRepository)
        {
            _inotlarRepository = inotlarRepository;
        }

        public IResult Add(Notlar notlar)
        {
            notlar.CreatedAt = DateTime.Now;
            _inotlarRepository.Add(notlar);
            var result = new SuccessResult("Kayıt başarılı bir şekilde ekdelendi");
            return result;
        }

      
        public IDataResult<Notlar> GetById(int Id)
        {
            return new SuccessDataResult<Notlar>(_inotlarRepository.Get(p => p.Id == Id));
        }

        public IDataResult<IList<Notlar>> GetList()
        {
            var data = _inotlarRepository.GetActiveList();
            var result = new  SuccessDataResult<IList<Notlar>>(data,"Başarılı");
            return result;
        }

       

        public IResult Remove(Notlar notlar)
        {
           _inotlarRepository.Delete(notlar);
            return new SuccessResult("Kayıt başarılı bir şekilde silindi");
        }

        public IResult Update(Notlar notlar)
        {
            notlar.UpdatedAt = DateTime.Now;
            _inotlarRepository.Update(notlar);
            return new SuccessResult("kayıt başarılı bir şekilde güncellendi");
        }

    }
}
