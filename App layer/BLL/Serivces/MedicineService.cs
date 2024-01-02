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
    public class MedicineService
    {
        public static List<MedicineDTO> Get()
        {
            var data = DataAccessFactory.MedicineData().Get();
            return Convert(data);
        }
        public static bool Create(MedicineDTO prj)
        {
            var data = Convert(prj);
            return DataAccessFactory.MedicineData().Create(data);
        }
        public static MedicineDTO Get(int id)
        {
            return Convert(DataAccessFactory.MedicineData().Get(id));
        }
        public static bool Update(MedicineDTO student)
        {
            var data = Convert(student);
            return DataAccessFactory.MedicineData().Update(data);
        }
        public static bool Delete(int id)
        {
            var medicine = DataAccessFactory.MedicineData();
            return medicine.Delete(id);
        }
        static List<MedicineDTO> Convert(List<Medicine> prj)
        {
            var data = new List<MedicineDTO>();
            foreach (Medicine i in prj)
            {
                data.Add(Convert(i));
            }
            return data;
        }
        static MedicineDTO Convert(Medicine prj)
        {
            return new MedicineDTO()
            {
                Id = prj.Id,
                Name = prj.Name,
               
                Quantity = prj.Quantity
            };
        }
        static Medicine Convert(MedicineDTO prj)
        {
            return new Medicine()
            {
                Id = prj.Id,
                Name = prj.Name,

                Quantity = prj.Quantity
            };
        }
    }
}
