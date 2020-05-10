﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication20.DAL;

namespace WebApplication20.Repository
{
  public  interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(int EmployeeID);

        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        void Save();


    }
}
