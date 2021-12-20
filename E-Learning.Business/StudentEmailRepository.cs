using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class StudentEmailRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Student_Email> GetAllStudentEmail()
		{
			List<Student_Email> emails = context.Student_Email.ToList();
			return emails;
		}

		public Student_Email GetStudentEmailById(int id)
		{
			Student_Email email = context.Student_Email.Find(id);
			return email;
		}

		public List<Student_Email> GetStudentEmailByStudentId(int id)
		{
			List<Student_Email> emails = context.Student_Email.Where(p => p.student_id == id).ToList();
			return emails;
		}

		public void Add(Student_Email email)
		{
			try
			{
				context.Student_Email.Add(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete (int id)
		{
			Student_Email email = context.Student_Email.Find(id);
			try
			{
				context.Student_Email.Remove(email);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update (Student_Email email)
		{
			Student_Email oldEmail = context.Student_Email.Find(email.id);
			try { 
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
