using HeladosES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeladosES.Services
{
    public interface IRecipienteService
    {
        Task<IEnumerable<Recipientes>> GetAll();
        Task<Recipientes> GetById(int id);
    }
}
