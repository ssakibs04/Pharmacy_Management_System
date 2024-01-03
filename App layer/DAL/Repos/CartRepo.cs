using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CartRepo : Repo, IProfile<Cart, int, bool>
    {
        public bool Add(Cart data)
        {
            throw new NotImplementedException();
        }

        public bool Create(Cart obj)
        {
            db.Carts.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var cart = Get(id);
            db.Carts.Remove(cart);
            return db.SaveChanges() > 0;
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }

        public List<Cart> GetCart(int medicine_id)
        {
            return (from cart in db.Carts
                    where cart.MedicineId == medicine_id
                    select cart).ToList(); ;
        }

        public bool Update(Cart obj)
        {
            var cart = Get(obj.Id);
            db.Entry(cart).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

		object IProfile<Cart, int, bool>.Create(Discount data)
		{
			throw new NotImplementedException();
		}

		bool IProfile<Cart, int, bool>.Update(Discount data)
		{
			throw new NotImplementedException();
		}
	}
}
