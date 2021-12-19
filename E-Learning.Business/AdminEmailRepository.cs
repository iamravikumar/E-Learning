using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class AdminEmailRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Admin_Email> GetAllAdminEmail()
		{
			List<Admin_Email> emails = context.Admin_Email.ToList();
			return emails;
		}

		public Admin_Email GetAdminEmailById(int id)
		{
			Admin_Email email = context.Admin_Email.Find(id);
			return email;
		}

		public void Add(Admin_Email email)
		{
			try
			{
				context.Admin_Email.Add(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Admin_Email email = context.Admin_Email.Find(id);
			try
			{
				context.Admin_Email.Remove(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Admin_Email email)
		{
			Admin_Email oldEmail = context.Admin_Email.Find(email.id);
			try
			{
				context.Entry(oldEmail).CurrentValues.SetValues(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
