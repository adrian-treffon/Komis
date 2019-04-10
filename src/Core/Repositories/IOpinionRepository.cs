﻿using Komis.Core.Models;
using System;
using System.Threading.Tasks;

namespace Komis.Core.Repositories
{
    public interface IOpinionRepository : IRepository
    {
        Task<Opinion> GetAsync(Guid id);
        Task AddAsync(Opinion opinion);
        Task DeleteAsync(Guid id);
    }
}