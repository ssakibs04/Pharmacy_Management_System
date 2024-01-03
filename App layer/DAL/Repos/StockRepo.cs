using DAL.Interface;
using DAL.Models;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

	public class StockRepo : Repo, IProfile<Stock, int, bool>
	{
		public bool Add(Cart data)
		{
			throw new NotImplementedException();
		}

		public bool Create(Stock obj)
		{
			db.Stocks.Add(obj);
			return db.SaveChanges() > 0;
		}

		public object Create(Discount data)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			var exstock = Get(id);
			db.Stocks.Remove(exstock);
			return db.SaveChanges() > 0;
		}

		public List<Stock> Get()
		{
			return db.Stocks.ToList();

		}

		public Stock Get(int id)
		{
			return db.Stocks.Find(id);
		}

		public List<Cart> GetCart(int medicine_id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Stock obj)
		{
			var exstock = Get(obj.Id);
			db.Entry(exstock).CurrentValues.SetValues(exstock);
			return db.SaveChanges() > 0;
		}

		public bool Update(Discount data)
		{
			throw new NotImplementedException();
		}
	}


}
	
	