using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class AdminFeedbackRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Admin_Feedback> GetAllAdminFeedbacks()
		{
			List<Admin_Feedback> feedbacks = context.Admin_Feedback.ToList();
			return feedbacks;
		}

		public Admin_Feedback GetAdminFeedbackById(int id)
		{
			Admin_Feedback feedbacks = context.Admin_Feedback.Find(id);
			return feedbacks;
		}

		public void Add(Admin_Feedback feedback)
		{
			try
			{
				context.Admin_Feedback.Add(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}

			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Admin_Feedback feedback = context.Admin_Feedback.Find(id);
			try
			{
				context.Admin_Feedback.Remove(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Admin_Feedback feedback)
		{
			Admin_Feedback oldFeedback = context.Admin_Feedback.Find(feedback.id);
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
