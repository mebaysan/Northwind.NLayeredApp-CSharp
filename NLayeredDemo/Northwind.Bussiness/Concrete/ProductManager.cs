using Northwind.Bussiness.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    // burada sadece iş kodları yazılır. Kullanıcı bu datayı görmeye yetkili mi? çektiği data görmesi gereken data mı vs..
    public class ProductManager:IProductService
    {
        private IProductDal _productDal; // bu sayede hangi veritabanı olursa olsun adapte olacağız
        public ProductManager(IProductDal productDal) // constructor sayesinde productmanager new'lendiğinde bana productdal türünde bir nesne ver
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
