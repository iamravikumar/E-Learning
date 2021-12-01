using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class RollRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Roll> GetAllRolls()
		{
			List<Roll> rolls = context.Rolls.ToList();
			return rolls;
		}

		public Roll GetRollById(int id)
		{
			Roll roll = context.Rolls.Find(id);
			return roll;
		}

		public void Add (Roll roll)
		{
			try
			{
				context.Rolls.Add(roll);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Roll roll = context.Rolls.Find(id);
			try { 
				context.Rolls.Remove(roll);
			}
			catch(Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Roll roll)
		{
			Roll oldRoll = context.Rolls.Find(roll.id);
			try
			{
				context.Entry(oldRoll).CurrentValues.SetValues(roll);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
