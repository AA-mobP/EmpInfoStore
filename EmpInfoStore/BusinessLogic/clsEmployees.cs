using EmpInfoStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpInfoStore.BusinessLogic
{
    internal class clsEmployees
    {
        private static ApplicationDbContext context = new();


        /// <summary>
        /// CRUD Operations: Create(Add method), Read(GetAll method + Get method), Update(Edit method), Delete(Remove method)
        /// </summary>

        public void Add(string txtName, int numSalary, string txtAddress)
        {
            EmployeeModel emp = new(){
                Name = txtName,
                Address = txtAddress,
                Salary = numSalary,
                CreatedDate = DateTime.Now};

            context.tblEmployees.Add(emp);
            context.SaveChanges();
            MessageBox.Show("Added!");
        }

        public List<EmployeeModel> GetAll()
        {
            return context.tblEmployees.Select(emp => emp).AsNoTracking().ToList();
        }

        public EmployeeModel? Get(int Id)
        {
            return context.tblEmployees.Select(emp => emp).Where(emp => emp.Id == Id).AsNoTracking().FirstOrDefault();
        }

        public void Edit(string txtName, int numSalary, string txtAddress, int Id)
        {
            EmployeeModel? emp = context.tblEmployees.FirstOrDefault(emp => emp.Id == Id);
            if (emp != null)
            {
                emp.Id = Id;
                emp.Name = txtName;
                emp.Salary = numSalary;
                emp.Address = txtAddress;

                context.tblEmployees.Update(emp);
                context.SaveChanges();
                MessageBox.Show("Edited!");
            }
            else
                MessageBox.Show("this field is Not Existing!");
        }

        public void Remove(int Id)
        {
            var emp = context.tblEmployees.FirstOrDefault(emp => emp.Id == Id);
            if (emp == null)
            {
                MessageBox.Show("Not Found!");
            }
            else
            {
                context.tblEmployees.Remove(emp);
                context.SaveChanges();
                MessageBox.Show("Done!");
            }
            
        }
    }
}
