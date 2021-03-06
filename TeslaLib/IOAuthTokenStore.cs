﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeslaLib.Models;

namespace TeslaLib
{
    public interface IOAuthTokenStore
    {
        Task<LoginToken> GetTokenAsync(string emailAddress);

        Task AddTokenAsync(string emailAddress, LoginToken token);

        Task UpdateTokenAsync(string emailAddress, LoginToken token);

        Task DeleteTokenAsync(string emailAddress);

        void ClearCache();
    }
}
