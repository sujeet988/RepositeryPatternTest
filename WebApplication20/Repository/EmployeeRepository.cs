using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication20.DAL;
using System.Data.Entity;


namespace WebApplication20.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeDBEntities _context;
        public EmployeeRepository()
        {
            _context = new EmployeeDBEntities();
        }

        public EmployeeRepository(EmployeeDBEntities context)
        {
            _context = context;
        }



        public void Delete(int EmployeeID)
        {
            Employee employee = _context.Employees.Find(EmployeeID);
            _context.Employees.Remove(employee);

        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int EmployeeID)
        {
            return _context.Employees.Find(EmployeeID);
        }



        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();

        }

        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }



        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }


    }
}