using Microsoft.EntityFrameworkCore;
using SafereWebApi.Interfaces;
using SafereWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafereWebApi.Services
{
    public class AdminService : IAdmin
    {
        private readonly SafereMainDBContext _mainDBContext;
        public AdminService(SafereMainDBContext db)
        {
            _mainDBContext = db;
        }

        public List<Admin> GetAllAdmins()
        {
            foreach (Admin item in _mainDBContext.Admins)
            {
                var p = _mainDBContext.Partners.First(p=>p.Id==item.PartnerId);
                item.Partner = p;
            }

            return _mainDBContext.Admins.ToList();
        }
    }
}
