using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using TechTest.Domain;

namespace TechTest.Data
{
    /// <summary>
    /// This class emulates the database access
    /// </summary>
    public class Repository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public Task<List<Robot>> GetRobots()
        {
            return GetRobots(x => true);
        }

        public async Task<List<Robot>> GetRobots(Expression<Func<Robot, bool>> conditions)
        {
            return context.Robots.Where(conditions).ToList();
        }
    }
}
