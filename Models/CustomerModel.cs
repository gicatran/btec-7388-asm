using ASM.Lib;
using ASM.Lib.Constants;
using System;

namespace ASM.Models {
    internal class CustomerModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerType Type { get; set; }
        public string DisplayType {
            get => Localizer.GetResource(Type.ToString().ToLower());
        }
        public int NumberOfPeople { get; set; }
        public int LastWaterReading { get; set; }
        public int CurrentWaterReading { get; set; }
        public int AmountOfConsumption {
            get {
                return CurrentWaterReading - LastWaterReading;
            }
        }

        public CustomerModel() {
            NumberOfPeople = 1;
        }

        public CustomerModel(int id, string name, CustomerType type, int numberOfPeople, int lastWaterReading, int currentWaterReading) {
            Id = id;
            Name = name;
            Type = type;
            NumberOfPeople = numberOfPeople;
            LastWaterReading = lastWaterReading;
            CurrentWaterReading = currentWaterReading;
        }

        public double CalculateTotalBill() {
            if (Type == CustomerType.HOUSEHOLD) {
                return CalculateHouseholdBill();
            }

            double price = Convert.ToDouble(AppConstants.PRICE_TABLE[Convert.ToInt32(Type)]);
            double cost = AmountOfConsumption * price * AppConstants.FEE;
            cost *= AppConstants.VAT;

            return cost;
        }

        private double CalculateHouseholdBill() {
            int averageConsumption = AmountOfConsumption / NumberOfPeople;
            double[] prices = (double[])AppConstants.PRICE_TABLE[Convert.ToInt32(CustomerType.HOUSEHOLD)];
            int[] limits = { 10, 10, 10, int.MaxValue };
            double cost = 0;

            for (int i = 0; i < limits.Length && averageConsumption > 0; i++) {
                int used = Math.Min(averageConsumption, limits[i]); // Math.Min() make sure it's calculated every tiered rates
                cost += used * prices[i] * AppConstants.FEE;
                averageConsumption -= used;
            }
            cost *= NumberOfPeople * AppConstants.VAT;
            return cost;
        }
    }
}
