using BlogLab.Models.Account;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IAccountRerpository
    {        
            public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,
                CancellationToken cancellationToken);

            public Task<ApplicationUserIdentity> GetByUsernameAsync(string NormalizedUseruser,
                CancellationToken cancellationToken);

    }
}
