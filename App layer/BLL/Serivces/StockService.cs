using BLL.DTOs;
using DAL;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Serivces
{
	public class StockService
	{
		public static object Create(StockDTO prj)
		{
			var data = Convert(prj);
			return DataAccessFactory.StockData().Create(data);
		}

		public static StockDTO Get(int id)
		{
			return Convert(DataAccessFactory.StockData().Get(id));
		}

		public static bool Update(StockDTO prj)
		{
			var data = Convert(prj);
			return DataAccessFactory.StockData().Update(data);
		}

		public static bool Delete(int id)
		{
			var stock = DataAccessFactory.StockData();
			return stock.Delete(id);
		}

		public static List<StockDTO> Get()
		{
			var data = DataAccessFactory.StockData().Get();
			return Convert(data);
		}

		static List<StockDTO> Convert(List<Stock> prj)
		{
			var data = new List<StockDTO>();
			foreach(Stock i in prj)
			{
				data.Add(Convert(i));

			}
			return data;
		}
		static StockDTO Convert(Stock prj)
		{
			return new StockDTO()
			{
				Id = prj.Id,
				Name = prj.Name,
				Description = prj.Description,
				Price = prj.Price,
			};
		}
		static Stock Convert(StockDTO prj)
		{
			return new Stock()
			{
				Id = prj.Id,
				Name = prj.Name,
				Description=prj.Description,
				Price = prj.Price,
			};
		}
	}



}
