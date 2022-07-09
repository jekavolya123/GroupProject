using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class BudgetContext : DbContext
    {
        public DbSet<Status> Statuses { set; get; }
        public DbSet<CandidateResults> CandidateResults { set; get; }
        public DbSet<Technology> Technologies { set; get; }
        public DbSet<TechnologyCandidateTables> TechnologyCandidateTables { set; get; }
        public DbSet<Candidates> Candidates { set; get; }
        public DbSet<Resumes> Resumes { set; get; }
        public DbSet<Comments> Comments { set; get; }
        public DbSet<Vacancies> Vacancies { set; get; }
        public DbSet<HRs> HRs { set; get; }

        public BudgetContext() : base("cs")
        {
            
            Database.SetInitializer<BudgetContext>(new CustomnInitializer());

        }
        
    }
}
