using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Library
{
    public class UsedCar : Car
    {
        public int Mileage { get; set; }
        public string Condition { get; set; }
        public UsedCar(string brand,int year,string vin,CarBodyType bodyType,decimal price, DateTime saleDate, string buyerFullName,int mileage,string condition)
            : base(brand, year, vin, bodyType, price, saleDate, buyerFullName)
        {
            Mileage = mileage;
            Condition = condition;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Подержанное авто. Пробег: {Mileage} км.";
            info[3] = $"Состояние: {Condition}.";

            return info;
        }
    }
}
