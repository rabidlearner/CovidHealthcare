using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;
using CovidHealthcareApi.Repository.Context;
using System.Data.Entity;

namespace CovidHealthcareApi.Repository
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly ApplicationDbContext dbContext;
        public HospitalRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void DeleteHospitalById(int id)
        {
            Hospital hospital = dbContext.Hospitals.Find(id);
            dbContext.Hospitals.Remove(hospital);
            dbContext.SaveChanges();
        }

        public List<Hospital> GetAllHospitals()
        {
            var hospitals = dbContext.Hospitals.ToList();

            return hospitals;
        }

        public Hospital GetHospitalById(int id)
        {
            var hospital = dbContext.Hospitals.SingleOrDefault(m => m.Id == id);

            return hospital;
        }

        public void CreateHospital(Hospital hospital)
        {
            dbContext.Hospitals.Add(hospital);
            dbContext.SaveChanges();

        }
        public void EditHospital(Hospital hospital)
        {
            dbContext.Entry(hospital).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
