using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
	internal class SupplierRepo : Repo, IProfile<Supplier, int, bool>
	{
		public bool Add(Cart data)
		{
			throw new NotImplementedException();
		}

		public bool Create(Supplier obj)
		{
			db.Suppliers.Add(obj);
			return db.SaveChanges() > 0;
			
				}

		public object Create(Discount data)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			var exsupplier =Get(id);
			db.Suppliers.Remove(exsupplier);
			return db.SaveChanges() > 0;
		}

		public List<Supplier> Get()
		{
			return db.Suppliers.ToList();	
		}

		public Supplier Get(int id)
		{
			return db.Suppliers.Find(id);
		}

		public List<Cart> GetCart(int medicine_id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Supplier obj)
		{
			var exsupplier = Get(obj.Id);
			db.Entry(exsupplier).CurrentValues.SetValues(exsupplier);
			return db.SaveChanges() > 0;
		}

		public bool Update(Discount data)
		{
			throw new NotImplementedException();
		}
	}
}
