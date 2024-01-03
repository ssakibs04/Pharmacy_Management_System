using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PharmacistRepo : Repo, IProfile<Staff, int, bool>
    {
        public bool Add(Cart data)
        {
            throw new NotImplementedException();
        }

        public bool Create(Staff obj)
        {
            db.Pharmacists.Add(obj);
            return db.SaveChanges() > 0;
        }

		public object Create(Discount data)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
        {
            var pharmacist = Get(id);
            db.Pharmacists.Remove(pharmacist);
            return db.SaveChanges() > 0;
        }

        public List<Staff> Get()
        {
            return db.Pharmacists.ToList();
        }

        public Staff Get(int id)
        {
            return db.Pharmacists.Find(id);
        }

        public List<Cart> GetCart(int medicine_id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Staff obj)
        {
            var pharmacist = Get(obj.Id);
            db.Entry(pharmacist).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

		public bool Update(Discount data)
		{
			throw new NotImplementedException();
		}
	}
}
