using GXXD.Domain.Entities;
using System.Collections.Generic;

namespace GXXD.WebUI.Models
{
    public class GrandListViewModel
    {
        public IEnumerable<Grand> Grands { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}