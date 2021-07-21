﻿using System;
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
            List<Hospital> hospitals = new List<Hospital>();
            List<Hospital> hospitalsNotInDatabase = new List<Hospital>();
            hospitals = dbContext.Hospitals.ToList();
            List<string> emails = new List<string>();
            emails = dbContext.Users.Select(m => m.Email).ToList();
            foreach (var hospital in hospitals)
            {
                if (!emails.Contains(hospital.Email))
                {
                    hospitalsNotInDatabase.Add(hospital);
                }
                else
                {
                    continue;
                }
            }

            return hospitalsNotInDatabase;
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
        public bool IsInDatabase(string email)
        {
            var obj = dbContext.Hospitals.FirstOrDefault(m => m.Email == email);
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
