using SafereWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafereWebApi.Interfaces
{
    public interface IAdmin
    {
        List<Admin> GetAllAdmins();
    }
}
