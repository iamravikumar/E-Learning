using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class AdminRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Admin> GetAllAdmins()
		{
			//create list of admins
			List<Admin> admins = context.Admins.ToList();
			return admins;
		}

		public Admin GetAdminByID(int id)
		{
			//find the admin that matches the passed id
			Admin admin = context.Admins.Find(id);
			return admin;
		}

		public void Add(Admin admin)
		{
			try
			{
				context.Admins.Add(admin);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Admin admin = context.Admins.Find(id);
			try
			{
				context.Admins.Remove(admin);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Admin admin)
		{
			Admin oldAdmin = context.Admins.Find(admin.id);
			try
			{
				context.Entry(oldAdmin).CurrentValues.SetValues(admin);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

	}
}
