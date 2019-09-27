using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer
{
    public interface IShopService
    {
        IQueryable<Phone> GetPhones();
        Phone GetPhoneById(int restaurantId);
        Photo GetPhotoById(int phoneid);
        Company GetCompanyById(int phoneid);
        Phone GetOnePhone(int phoneid);
    }
}
