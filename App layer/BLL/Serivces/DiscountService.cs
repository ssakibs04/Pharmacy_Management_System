using BLL.DTOs;
using DAL;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
	public class DiscountService
	{
		public static object Create(DiscountDTO discountDTO)
		{
			var data = Convert(discountDTO);
			return DataAccessFactory.DiscountData().Create(data);
		}

		public static DiscountDTO Get(int discountId)
		{
			return Convert(DataAccessFactory.DiscountData().Get(discountId));
		}

		public static bool Update(DiscountDTO discountDTO)
		{
			var data = Convert(discountDTO);
			return DataAccessFactory.DiscountData().Update(data);
		}

		public static bool Delete(int id)
		{
			var discountData = DataAccessFactory.DiscountData();
			return discountData.Delete(id);
		}

		public static List<DiscountDTO> Get()
		{
			var data = DataAccessFactory.DiscountData().Get();
			return Convert(data);
		}

		private static List<DiscountDTO> Convert(List<Discount> discountList)
		{
			var discountDTOList = new List<DiscountDTO>();
			foreach (Discount discount in discountList)
			{
				discountDTOList.Add(Convert(discount));
			}
			return discountDTOList;
		}

		private static DiscountDTO Convert(Discount discount)
		{
			return new DiscountDTO()
			{
				DiscountID = discount.DiscountID,
				MedicineID = discount.MedicineID,
				CustomerID = discount.CustomerID,
				DiscountPercentage = discount.DiscountPercentage,
				StartDate = discount.StartDate,
				EndDate = discount.EndDate,
			};
		}

		private static Discount Convert(DiscountDTO discountDTO)
		{
			return new Discount()
			{
				DiscountID = discountDTO.DiscountID,
				MedicineID = discountDTO.MedicineID,
				CustomerID = discountDTO.CustomerID,
				DiscountPercentage = discountDTO.DiscountPercentage,
				StartDate = discountDTO.StartDate,
				EndDate = discountDTO.EndDate,
			};
		}
	}
}
