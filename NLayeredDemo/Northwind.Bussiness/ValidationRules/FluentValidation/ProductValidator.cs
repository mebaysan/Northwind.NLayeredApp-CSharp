using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> // ürün için kurallar yazacağız
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz"); // ProductName'i boş olamaz
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0); // unit stock = 0'dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2); // unit price category id 2'ye eşit olduğu zaman 10'dan büyük olmalı

        }
    }
}
