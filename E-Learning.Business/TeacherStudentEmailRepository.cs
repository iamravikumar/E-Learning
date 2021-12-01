using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class TeacherStudentEmailRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Teacher_Student_Email > GetAllTeacherStudentEmails()
		{
			List<Teacher_Student_Email> emails = context.Teacher_Student_Email.ToList();
			return emails;
		}

		public Teacher_Student_Email GetTeacherStudentEmailById(int id)
		{
			Teacher_Student_Email email = context.Teacher_Student_Email.Find(id);
			return email;
		}

		public void Add(Teacher_Student_Email email)
		{
			try
			{
				context.Teacher_Student_Email.Add(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Teacher_Student_Email email = context.Teacher_Student_Email.Find(id);
			try
			{
				context.Teacher_Student_Email.Remove(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Teacher_Student_Email email)
		{
			Teacher_Student_Email oldEmail = context.Teacher_Student_Email.Find(email.id);
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
