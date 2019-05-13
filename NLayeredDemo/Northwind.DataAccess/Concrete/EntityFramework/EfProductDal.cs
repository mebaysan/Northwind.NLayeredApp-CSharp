using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal // interface sayesinde yarın öbür gün başka bir veritabanı ile çalışmak istersek değişimi kolaylaştıracak
    {
        // ürün ile ilgili crud işlemlerinin olacağı bölümü hazırladık.

    }
}