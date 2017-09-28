using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GXBMXD.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string usernme, string password);
    }
}