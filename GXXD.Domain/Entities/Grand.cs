using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GXXD.Domain.Entities
{
    public class Grand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal 科目一 { get; set; }
        public decimal 科目二 { get; set; }
        public decimal 科目三 { get; set; }
    }
}