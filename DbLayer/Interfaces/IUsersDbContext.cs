﻿using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer.Interfaces
{
    public interface IUsersDbContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}