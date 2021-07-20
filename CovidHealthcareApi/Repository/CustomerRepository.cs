using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;
using CovidHealthcareApi.Repository.Context;
using System.Data.Entity;

namespace CovidHealthcareApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CustomerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void DeleteCustomerById(int id)
        {
            Customer customer = dbContext.Customers.Find(id);
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = dbContext.Customers.ToList();

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            var customer = dbContext.Customers.SingleOrDefault(m => m.Id == id);

            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();

        }
        public void EditCustomer(Customer customer)
        {
            dbContext.Entry(customer).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
