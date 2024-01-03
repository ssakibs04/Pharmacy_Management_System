using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IProfile<TYPE, ID, RET>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        RET Create(TYPE obj);
        RET Update(TYPE obj);
        bool Delete(ID id);
        List<Cart> GetCart(int medicine_id);
        bool Add(Cart data);
		object Create(Discount data);
		bool Update(Discount data);
	}
}
