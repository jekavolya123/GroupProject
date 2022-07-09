using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class CustomnInitializer : DropCreateDatabaseIfModelChanges<BudgetContext>
    {
        protected override void Seed(BudgetContext context)
        {

            base.Seed(context);
        }
    }
}
