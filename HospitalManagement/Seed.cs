using HospitalManagement.Data;
using HospitalManagement.Models;
//using System.Diagnostics.Metrics;

namespace HospitalManagement
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Categories.Any())
            {
                var categories = new List<Category>()
        {
            new Category()
            {
                Name = "Consult"
            },
            new Category()
            {
                Name = "Invest"
            }
        };

                dataContext.Categories.AddRange(categories);
                dataContext.SaveChanges();
            }
        }
    }
}
