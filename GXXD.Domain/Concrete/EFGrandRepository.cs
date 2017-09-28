using System;
using System.Linq;
using GXXD.Domain.Abstract;
using GXXD.Domain.Entities;

namespace GXXD.Domain.Concrete
{
    public class EFGrandRepository : IProdustRepositiory
    {
        private EFDContext context = new EFDContext();

        public IQueryable<Grand> Grands
        {
            get
            {
                return context.Grands;
            }
        }
            public void SaveProduct(Grand grands)
        {

            if (grands.Id == 0)
            {
                context.Grands.Add(grands);
            }
            else
            {
                Grand dbEntry = context.Grands.Find(grands.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = grands.Name;
                    dbEntry.科目一 = grands.科目一;
                    dbEntry.科目二 = grands.科目二;
                    dbEntry.科目三 = grands.科目三;
                }
            }
            context.SaveChanges();
        }


    }
}
