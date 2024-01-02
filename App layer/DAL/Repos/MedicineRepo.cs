using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
   public class MedicineRepo : Repo, IProfile<Medicine, int, bool>
    {
        public bool Add(Cart data)
        {
            throw new NotImplementedException();
        }

        public bool Create(Medicine obj)
        {
            db.Medicines.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var medicine = Get(id);
            db.Medicines.Remove(medicine);
            return db.SaveChanges() > 0;
        }

        public List<Medicine> Get()
        {
            return db.Medicines.ToList();
        }

        public Medicine Get(int id)
        {
            return db.Medicines.Find(id);
        }

        public List<Cart> GetCart(int medicine_id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Medicine obj)
        {
            var medicine = Get(obj.Id);
            db.Entry(medicine).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
