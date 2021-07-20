﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IDoctorCommandService
    {
        void CreateDoctor(Doctor Doctor);
        void DeleteDoctorById(int id);
        void EditDoctor(Doctor Doctor);
    }
}
