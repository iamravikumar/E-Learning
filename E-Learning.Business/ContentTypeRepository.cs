using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class ContentTypeRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Content_Type> GetAllContentTypes()
		{
			List<Content_Type> types = context.Content_Type.ToList();
			return types;
		}

		public Content_Type GetContentTypeById(int id)
		{
			Content_Type type = context.Content_Type.Find(id);
			return type;
		}

		public void Add(Content_Type type)
		{
			try
			{
				context.Content_Type.Add(type);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Content_Type type = context.Content_Type.Find(id);
			try
			{
				context.Content_Type.Remove(type);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Content_Type type)
		{
			Content_Type oldType = context.Content_Type.Find(type.id);
			try
			{
				context.Entry(oldType).CurrentValues.SetValues(type);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
