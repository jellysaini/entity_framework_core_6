using EFCore6.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6.Application
{
    public interface IAccountUserRepository
    {
        Task<List<AccountUser>> GetAll();
    }
}
