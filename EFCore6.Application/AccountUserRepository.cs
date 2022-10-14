using EFCore6.Infrastructure;
using EFCore6.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6.Application
{
    public class AccountUserRepository : IAccountUserRepository
    {
        private readonly EFCore6DbContext _dbContext;
        public AccountUserRepository(EFCore6DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<AccountUser>> GetAll()
        {
            return await _dbContext.AccountUser.ToListAsync();
        }
    }
}
