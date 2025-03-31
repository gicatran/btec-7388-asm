using ASM.Lib;
using ASM.Models;
using System.ComponentModel;

namespace ASM.Controllers {
    internal class CustomerController {
        public BindingList<CustomerModel> GetCustomers() {
            return Database.GetCustomers();
        }

        public void AddCustomer(CustomerModel customer) {
            Database.SaveData(customer);
        }

        public void UpdateCustomer(int index, CustomerModel customer) {
            if (index >= 0 && index < Database.GetCustomers().Count) {
                Database.UpdateData(customer);
            }
        }

        public void DeleteCustomer(int index) {
            if (index >= 0 && index < Database.GetCustomers().Count) {
                Database.DeleteData(index);
            }
        }

        public BindingList<CustomerModel> SearchCustomers(string query) {
            return new BindingList<CustomerModel>(Database.SearchCustomers(query));
        }
    }
}
