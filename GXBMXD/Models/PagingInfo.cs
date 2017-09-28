using System;

namespace GXXD.WebUI.Models
{
    public class PagingInfo
    {
        public int ToTalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)ToTalItems / ItemsPerPage); }
        }
    }
}