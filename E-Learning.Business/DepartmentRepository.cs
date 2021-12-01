using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class DepartmentRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Department> GetAllDepartments()
		{
			List<Department> departments = context.Departments.ToList();
			return departments;
		}

		public Department GetDepartmentById(int id)
		{
			Department department = context.Departments.Find(id);
			return department;
		}

		public void Add(Department department)
		{
			try
			{
				context.Departments.Add(department);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Department department = context.Departments.Find(id);
			try
			{
				context.Departments.Remove(department);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Department department)
		{
			Department oldDepartment = context.Departments.Find(department.id);
			try
			{
				context.Entry(oldDepartment).CurrentValues.SetValues(department);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

	}
}
