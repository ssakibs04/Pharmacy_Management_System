using BLL.DTOs;
using DAL;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Serivces
{
    public  class PharmacistService
    {
        public static object Create(PharmacistDTO prj)
        {
            var data = Convert(prj);
            return DataAccessFactory.PharmacistData().Create(data);
        }
        public static PharmacistDTO Get(int id)
        {
            return Convert(DataAccessFactory.PharmacistData().Get(id));
        }
        public static bool Update(PharmacistDTO pharmacist)
        {
            var data = Convert(pharmacist);
            return DataAccessFactory.PharmacistData().Update(data);
        }
        public static bool Delete(int id)
        {
            var pharmacist = DataAccessFactory.PharmacistData();
            return pharmacist.Delete(id);
        }

        public static List<PharmacistDTO> Get()
        {
            var data = DataAccessFactory.PharmacistData().Get();
            return Convert(data);
        }

        static List<PharmacistDTO> Convert(List<Pharmacist> prj)
        {
            var data = new List<PharmacistDTO>();
            foreach (Pharmacist i in prj)
            {
                data.Add(Convert(i));
            }
            return data;
        }

        static PharmacistDTO Convert(Pharmacist prj)
        {
            return new PharmacistDTO()
            {
                Id = prj.Id,
                Name = prj.Name,
                Age = prj.Age,
                Username = prj.Username,
                Password = prj.Password,
            };
        }
        static Pharmacist Convert(PharmacistDTO prj)
        {
            return new Pharmacist()
            {
                Id = prj.Id,
                Name = prj.Name,
                Age = prj.Age,
                Username = prj.Username,
                Password = prj.Password,
            };
        }
    }
}
