using BLL.DTOs;
using DAL.Models.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Serivces
{
	public class SupplierService
	{
		public static object Create(SupplierDTO prj)
		{
			var data = Convert(prj);
			return DataAccessFactory.SupplierData().Create(data);
		}

		public static SupplierDTO Get(int id)
		{
			return Convert(DataAccessFactory.SupplierData().Get(id));
		}

		public static bool Update(SupplierDTO prj)
		{
			var data = Convert(prj);
			return DataAccessFactory.SupplierData().Update(data);
		}

		public static bool Delete(int id)
		{
			var Supplier = DataAccessFactory.SupplierData();
			return Supplier.Delete(id);
		}

		public static List<SupplierDTO> Get()
		{
			var data = DataAccessFactory.SupplierData().Get();
			return Convert(data);
		}

		static List<SupplierDTO> Convert(List<Supplier> prj)
		{
			var data = new List<SupplierDTO>();
			foreach (Supplier i in prj)
			{
				data.Add(Convert(i));

			}
			return data;
		}
		static SupplierDTO Convert(Supplier prj)
		{
			return new SupplierDTO()
			{
				Id = prj.Id,
				CompanyName = prj.CompanyName,
				Address = prj.Address,
				Email = prj.Email,
			};
		}
		static Supplier Convert(SupplierDTO prj)
		{
			return new Supplier()
			{
				Id = prj.Id,
				CompanyName= prj.CompanyName,
				Address = prj.Address,
				Email = prj.Email,
			};
		}
	}


}


