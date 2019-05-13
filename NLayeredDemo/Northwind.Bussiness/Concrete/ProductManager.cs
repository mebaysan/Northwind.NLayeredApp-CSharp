using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    // burada sadece iş kodları yazılır. Kullanıcı bu datayı görmeye yetkili mi? çektiği data görmesi gereken data mı vs..
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
