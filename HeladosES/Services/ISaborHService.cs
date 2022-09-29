using HeladosES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeladosES.Services
{
    public interface ISaborHService
    {
        Task<IEnumerable<SaborH>> GetAll();
        Task<SaborH> GetById(int id);
    }
}
