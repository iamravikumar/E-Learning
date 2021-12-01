using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class BranchRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Branch> GetAllBranches()
		{
			List<Branch> branches = context.Branches.ToList();
			return branches;
		}

		public Branch GetBranchById(int id)
		{
			Branch branch = context.Branches.Find(id);
			return branch;
		}

		public void Add(Branch branch)
		{
			try
			{
				context.Branches.Add(branch);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Branch branch = context.Branches.Find(id);
			try
			{
				context.Branches.Remove(branch);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Branch branch)
		{
			Branch oldBranch = context.Branches.Find(branch.id);
			try
			{
				context.Entry(oldBranch).CurrentValues.SetValues(branch);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
