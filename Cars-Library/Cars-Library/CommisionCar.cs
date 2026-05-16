using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Library
{
    public class CommissionCar : UsedCar
    {
        public string OwnerFullName { get; set; }
        public string OwnerAddress { get; set; }
        public string ContractNumber { get; set; }

        public CommissionCar(string brand,int year, string vin,
            CarBodyType bodyType,
            decimal price,
            DateTime saleDate,
            string buyerFullName,
            int mileage,
            string condition,
            string ownerFullName,
            string ownerAddress,
            string contractNumber)
            : base(brand,year,vin,bodyType,price,saleDate,buyerFullName,mileage,condition)
        {
            OwnerFullName = ownerFullName;
            OwnerAddress = ownerAddress;
            ContractNumber = contractNumber;
        }

        public override string[] GetInfo()
        {
            var info = new string[7];

            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = baseInfo[2];
            info[3] = baseInfo[3];
            info[4] = $"Комиссионное авто.";
            info[5] = $"Владелец: {OwnerFullName}. Адрес: {OwnerAddress}.";
            info[6] = $"Номер договора: {ContractNumber}.";

            return info;
        }
    }
}
