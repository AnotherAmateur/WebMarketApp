﻿using Application.Services;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace Application.Services
{
    public interface ITaskItemRep : IEntityBaseRep<TaskItem>
    {
        Task<TaskItem?> GetByIdAsync(int id);
        IEnumerable<TaskItem> GetAllUnremoved();
        Task DeleteAsync(TaskItem task);
    }
}
