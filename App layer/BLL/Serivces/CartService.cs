using BLL.DTOs;
using DAL;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Serivces
{
    public class CartService
    {
        public static List<CartDTO> GetCart(int medicine_id)
        {
            var data = DataAccessFactory.CartData().GetCart(medicine_id);
            return Convert(data);
        }
        public static bool Create(CartDTO cart)
        {
            var data = Convert(cart);
            return DataAccessFactory.CartData().Add(data);
        }
        public static bool Delete(int id)
        {
            var cart = DataAccessFactory.CartData();
            return cart.Delete(id);
        }

        static List<CartDTO> Convert(List<Cart> prj)
        {
            var data = new List<CartDTO>();
            foreach (Cart i in prj)
            {
                data.Add(Convert(i));
            }
            return data;
        }
        static CartDTO Convert(Cart prj)
        {
            return new CartDTO()
            {
                Id = prj.Id,
               
                MedicineId = prj.MedicineId
            };
        }
        static Cart Convert(CartDTO prj)
        {
            return new Cart()
            {
                Id = prj.Id,
              
                MedicineId = prj.MedicineId
            };
        }
    }
}
