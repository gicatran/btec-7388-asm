using ASM.Constants;
using ASM.Lib.Constants;
using ASM.Lib.Types;
using ASM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace ASM.Lib {
    internal static class Database {
        private readonly static SortableBindingList<CustomerModel> customerTable = new SortableBindingList<CustomerModel>();

        public static void Init() {
            try {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ResourceConstants.DATABASE_FILE);

                using (StreamReader reader = new StreamReader(filePath)) {
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();

                        if (!string.IsNullOrWhiteSpace(line)) {
                            string[] parts = line.Split(',');

                            CustomerModel customer = new CustomerModel(
                                int.Parse(parts[0]),
                                parts[1],
                                (CustomerType)int.Parse(parts[2]),
                                int.Parse(parts[3]),
                                int.Parse(parts[4]),
                                int.Parse(parts[5])
                            );

                            customerTable.Add(customer);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void SaveToFile() {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ResourceConstants.DATABASE_FILE);

            using (StreamWriter writer = new StreamWriter(filePath)) {
                foreach (CustomerModel customer in customerTable) {
                    writer.WriteLine($"{customer.Id},{customer.Name},{(int)customer.Type},{customer.NumberOfPeople},{customer.LastWaterReading},{customer.CurrentWaterReading}");
                }
            }
        }

        public static List<CustomerModel> SearchCustomers(string query) {
            return GetCustomers()
                .Where(c => c.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public static void SaveData(CustomerModel customer) {
            customerTable.Add(customer);
            SaveToFile();
        }

        public static void UpdateData(CustomerModel customer) {
            customerTable[customer.Id - 1] = customer;
            SaveToFile();
        }

        public static void DeleteData(int selectedIndex) {
            customerTable.RemoveAt(selectedIndex);
        }

        public static BindingList<CustomerModel> GetCustomers() {
            return customerTable;
        }
    }
}
