using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer
{
    public class ShopService : IShopService
    {
        private readonly ShopContext _shopContext;

        public ShopService(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public IQueryable<Phone> GetPhones()
        {
            var telefoner = _shopContext.Phones.Include(x => x.Company).Include(x => x.Photo);
            return telefoner;
        }

        public Phone GetPhoneById(int phoneid)
        {
            return _shopContext.Phones.Find(phoneid);
        }

        public Photo GetPhotoById(int phoneid)
        {
            return _shopContext.Photos.Find(phoneid);
        }

        public Company GetCompanyById(int phoneid)
        {
            return _shopContext.Companies.FirstOrDefault(x => x.CompanyID == 1 );
        }

        public Phone GetOnePhone(int phoneid)
        {
            return _shopContext.Phones.Include(x => x.Company).Include(x => x.Photo).FirstOrDefault(p => p.PhoneID == phoneid);
        }
    }
}
