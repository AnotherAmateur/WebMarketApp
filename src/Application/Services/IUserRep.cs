﻿using Application.Interfaces;
using Application.Services;
using Domain.Entities;

namespace Application.Services
{
    public interface IUserRep: IEntityBaseRep<User>
    {
        Task<User?> GetByIdAsync(string id);
        Task<User?> GetByEmailAsync(string email);
        IEnumerable<User> GetAllUnremoved();
        Task DeleteAsync(User user);
    }
}
