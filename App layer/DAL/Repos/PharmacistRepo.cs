using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PharmacistRepo : Repo, IProfile<Pharmacist, int, bool>
    {
        public bool Add(Cart data)
        {
            throw new NotImplementedException();
        }

        public bool Create(Pharmacist obj)
        {
            db.Pharmacists.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var pharmacist = Get(id);
            db.Pharmacists.Remove(pharmacist);
            return db.SaveChanges() > 0;
        }

        public List<Pharmacist> Get()
        {
            return db.Pharmacists.ToList();
        }

        public Pharmacist Get(int id)
        {
            return db.Pharmacists.Find(id);
        }

        public List<Cart> GetCart(int medicine_id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pharmacist obj)
        {
            var pharmacist = Get(obj.Id);
            db.Entry(pharmacist).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
