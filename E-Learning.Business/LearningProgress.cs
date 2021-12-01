using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class LearningProgress
	{
		ELearningDB context = new ELearningDB();

		public List<Learning_Progress> GetAllLearningProgress()
		{
			List<Learning_Progress> progresses = context.Learning_Progress.ToList();
			return progresses;
		}

		public Learning_Progress GetLearnProgressById(int id)
		{
			Learning_Progress progress = context.Learning_Progress.Find(id);
			return progress;
		}

		public void Add(Learning_Progress progress)
		{
			try
			{
				context.Learning_Progress.Add(progress);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Learning_Progress progress = context.Learning_Progress.Find(id);
			try
			{
				context.Learning_Progress.Remove(progress);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Learning_Progress progress)
		{
			Learning_Progress oldProgress = context.Learning_Progress.Find(progress.id);
			try { 
				context.Entry(oldProgress).CurrentValues.SetValues(progress);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
