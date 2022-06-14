using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    public class DbPeopleServiceAdapter : IPeopleService
    {
        private DbPeopleService _dbPeopleService;

        public DbPeopleServiceAdapter(DbPeopleService dbPeopleService)
        {
            _dbPeopleService = dbPeopleService;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _dbPeopleService.Read();

            return people.Select(x => new Person { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Now.Year - x.BirthDate.Year });
        }
    }
}
