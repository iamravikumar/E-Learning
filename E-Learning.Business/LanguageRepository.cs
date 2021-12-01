using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class LanguageRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Language> GetAllLanguages()
		{
			List<Language> languages = context.Languages.ToList();
			return languages;
		}

		public Language GetLanguageById(int id)
		{
			Language language = context.Languages.Find(id);
			return language;
		}

		public void Add(Language language)
		{
			try
			{
				context.Languages.Add(language);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Language language = context.Languages.Find(id);
			try
			{
				context.Languages.Remove(language);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Language language)
		{
			Language oldLanguage = context.Languages.Find(language.id);
			try
			{
				context.Entry(oldLanguage).CurrentValues.SetValues(language);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
