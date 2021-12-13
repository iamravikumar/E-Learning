using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class StudentFeedbackRepository
	{
		ELearningDB context = new ELearningDB();

		public List<Student_Feedback> GetAllAdminFeedbacks()
		{
			List<Student_Feedback> feedbacks = context.Student_Feedback.ToList();
			return feedbacks;
		}

		public Student_Feedback GetAdminFeedbackById(int id)
		{
			Student_Feedback feedbacks = context.Student_Feedback.Find(id);
			return feedbacks;
		}

		public void Add(Student_Feedback feedback)
		{
			try
			{
				context.Student_Feedback.Add(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}

			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Student_Feedback feedback = context.Student_Feedback.Find(id);
			try
			{
				context.Student_Feedback.Remove(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Student_Feedback feedback)
		{
			Student_Feedback oldFeedback = context.Student_Feedback.Find(feedback.id);
			try
			{
				context.Entry(oldFeedback).CurrentValues.SetValues(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
