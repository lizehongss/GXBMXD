using GXXD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GXXD.Domain.Abstract
{
    public interface IProdustRepositiory
    {
        IQueryable<Grand> Grands { get; }
        void SaveProduct(Grand grands);
    }
}