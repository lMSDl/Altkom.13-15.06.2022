using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class CustomerService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        private Customer FindById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }
    }
}
