using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class FeedbackRepository
	{
		ELearningDB context = new ELearningDB();

		public List<Feedback> GetAllFeedback()
		{
			List<Feedback> feedbacks = context.Feedbacks.ToList();
			return feedbacks;
		}

		public Feedback GetFeedbackById(int id)
		{
			Feedback feedback = context.Feedbacks.Find(id);
			return feedback;
		}

		public void Add(Feedback feedback)
		{
			try
			{
				context.Feedbacks.Add(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Feedback feedback = context.Feedbacks.Find(id);
			try
			{
				context.Feedbacks.Remove(feedback);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Feedback feedback)
		{
			Feedback oldFeedback = context.Feedbacks.Find(feedback.id);
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
