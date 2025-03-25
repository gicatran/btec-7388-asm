using ASM.Lib;
using ASM.Models;
using System.ComponentModel;

namespace ASM.Controllers {
    internal class CustomerController {
        private readonly BindingList<CustomerModel> customers;

        public CustomerController() {
            customers = new BindingList<CustomerModel>(Database.GetCustomers());
        }

        public BindingList<CustomerModel> GetCustomers() {
            return customers;
        }

        public void AddCustomer(CustomerModel customer) {
            customers.Add(customer);
            Database.SaveData(customer);
        }

        public void UpdateCustomer(int index, CustomerModel customer) {
            if (index >= 0 && index < customers.Count) {
                customers[index] = customer;
                Database.UpdateData(customer);
            }
        }

        public void DeleteCustomer(int index) {
            if (index >= 0 && index < customers.Count) {
                Database.DeleteData(index);
                customers.RemoveAt(index);
            }
        }

        public BindingList<CustomerModel> SearchCustomers(string query) {
            return new BindingList<CustomerModel>(Database.SearchCustomers(query));
        }
    }
}
