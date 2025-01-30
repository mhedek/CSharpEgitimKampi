using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // T değeri mutlaka class olmalı
    {
        void Insert(T entity); // ekleme işlemi
        void Update(T entity); // güncelleme işlemi
        void Delete(T entity); // silme işlemi
        List<T> GetAll(); // listeleme işlemi
        T GetById(int id); // ID göre getirme işlemi

    }
}
