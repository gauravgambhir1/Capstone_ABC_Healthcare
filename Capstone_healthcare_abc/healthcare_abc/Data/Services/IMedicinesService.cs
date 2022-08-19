using E_Healthcare_CapstoneProject_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Healthcare_CapstoneProject_LMS.Data.Services
{
   public interface IMedicinesService
    {
        Task<IEnumerable<Medicine>> GetAll();
        Task<Medicine> GetByID(int id);
        Task Add(Medicine medicine);
        Task<Medicine> Update(int id, Medicine newMedicine);
        Task Delete(int id);
        
    }
}
