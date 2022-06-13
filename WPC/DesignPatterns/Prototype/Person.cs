using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Prototype
{
    public class Person : ICloneable
    {
        public Person Parent { get; set; }

        public ICollection<Person> Children { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();

            return clone;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
        }
    }
}
