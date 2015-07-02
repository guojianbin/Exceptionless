﻿using System;
using System.Threading.Tasks;
using Exceptionless.Core.Models;

namespace Exceptionless.Core.Repositories {
    public interface IRepositoryOwnedByProject<T> : IRepository<T> where T : class, IOwnedByProject, IIdentity, new() {
        FindResults<T> GetByProjectId(string projectId, PagingOptions paging = null, bool useCache = false, TimeSpan? expiresIn = null);
        Task RemoveAllByProjectIdsAsync(string[] projectIds);
    }
}