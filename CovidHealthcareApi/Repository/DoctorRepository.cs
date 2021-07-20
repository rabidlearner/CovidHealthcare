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
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext dbContext;
        public DoctorRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void DeleteDoctorById(int id)
        {
            Doctor Doctor = dbContext.Doctors.Find(id);
            dbContext.Doctors.Remove(Doctor);
            dbContext.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            var Doctors = dbContext.Doctors.ToList();

            return Doctors;
        }

        public Doctor GetDoctorById(int id)
        {
            var Doctor = dbContext.Doctors.SingleOrDefault(m => m.Id == id);

            return Doctor;
        }

        public void CreateDoctor(Doctor Doctor)
        {
            dbContext.Doctors.Add(Doctor);
            dbContext.SaveChanges();

        }
        public void EditDoctor(Doctor Doctor)
        {
            dbContext.Entry(Doctor).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
