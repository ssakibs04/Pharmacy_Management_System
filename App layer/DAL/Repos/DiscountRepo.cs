using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
	public class DiscountRepo : Repo, IProfile<Discount, int, bool>
	{
		public bool Add(Cart data)
		{
			throw new NotImplementedException();
		}

		public bool Create(Discount obj)
		{
			db.Discounts.Add(obj);
			return db.SaveChanges() > 0;
		}

		public bool Delete(int id)
		{
			var exdiscount = Get(id);
			db.Discounts.Remove(exdiscount);
			return db.SaveChanges() > 0;
		}

		public List<Discount> Get()
		{
			return db.Discounts.ToList();

		}

		public Discount Get(int id)
		{
			return db.Discounts.Find(id);
		}

		public List<Cart> GetCart(int medicine_id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Discount obj)
		{
			var exdiscount = Get(obj.DiscountID);
			db.Entry(exdiscount).CurrentValues.SetValues(exdiscount);
			return db.SaveChanges() > 0;
		}

		object IProfile<Discount, int, bool>.Create(Discount data)
		{
			throw new NotImplementedException();
		}
	}


}
