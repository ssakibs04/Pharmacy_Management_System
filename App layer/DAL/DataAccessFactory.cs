using DAL.Interface;
using DAL.Models.Entities;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IProfile<Staff, int, bool> PharmacistData()
        {
            return new PharmacistRepo();
        }

        public static IProfile<Sale, int, bool> SaleData()
        {
            return new SaleRepo();
        }

        public static IProfile<Cart, int, bool> CartData()
        {
            return new CartRepo();
        }

        public static IProfile<Medicine, int, bool> MedicineData()
        {
            return new MedicineRepo();
        } 
        
        public static IProfile<Stock, int, bool> StockData()
        {
            return new StockRepo();
        }
     public static IProfile<Supplier, int, bool> SupplierData()
        {
            return new SupplierRepo();
        }
        
        public static IProfile<Discount, int, bool> DiscountData()
        {
            return new DiscountRepo();
        }
    }
}
