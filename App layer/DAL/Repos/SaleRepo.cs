using DAL.Interface;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SaleRepo : Repo, IProfile<Sale, int, bool>
    {
        public bool Add(Cart data)
        {
            throw new NotImplementedException();
        }

        public bool Create(Sale obj)
        {
            db.Sales.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var sale = Get(id);
            db.Sales.Remove(sale);
            return db.SaveChanges() > 0;
        }

        public List<Sale> Get()
        {
            return db.Sales.ToList();
        }

        public Sale Get(int id)
        {
            return db.Sales.Find(id);
        }

        public List<Cart> GetCart(int medicine_id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sale obj)
        {
            var sale = Get(obj.Id);
            db.Entry(sale).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
