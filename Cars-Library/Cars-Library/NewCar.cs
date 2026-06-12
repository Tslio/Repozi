    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Cars_Library
    {   public class NewCar : Car
        {
            public string Manufacturer {get; set;}
            public int WarrantyPeriod  {get; set;}
            public NewCar(
                string brand,
                int year,
                string vin,
                CarBodyType bodyType,
                decimal price,
                DateTime saleDate,
                string buyerFullName,
                string manufacturer,
                int warrantyPeriod)
                : base(brand, year, vin, bodyType, price, saleDate, buyerFullName)
            {
                Manufacturer = manufacturer;
                WarrantyPeriod = warrantyPeriod;
            }

            public override string[] GetInfo()
            {
                var info = new string[4];
                var baseInfo = base.GetInfo();

                info[0] = baseInfo[0];
                info[1] = baseInfo[1];
                info[2] = $"Новое авто. Завод-производитель: {Manufacturer}.";
                info[3] = $"Гарантийный срок: {WarrantyPeriod} мес.";

                return info;
            }
        }
    }
