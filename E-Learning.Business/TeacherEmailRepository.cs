using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;
using System.Collections;

namespace E_Learning.Business
{
	public class TeacherEmailRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Teacher_Email> GetAllTeacherEmail()
		{
			List<Teacher_Email> emails = context.Teacher_Email.ToList();
			return emails;
		}

		public Teacher_Email GetTeacherEmailById(int id)
		{
			Teacher_Email email = context.Teacher_Email.Find(id);
			return email;
		}

		public void Add(Teacher_Email email)
		{
			try
			{
				context.Teacher_Email.Add(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Teacher_Email email = context.Teacher_Email.Find(id);
			try
			{
				context.Teacher_Email.Remove(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Teacher_Email email)
		{
			Teacher_Email oldEmail = context.Teacher_Email.Find(email.id);
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
