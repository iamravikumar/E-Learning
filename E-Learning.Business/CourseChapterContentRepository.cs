using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class CourseChapterContentRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Course_Chapter_Content> GetAllCouserChapterContents()
		{
			List<Course_Chapter_Content> contents = context.Course_Chapter_Content.ToList();
			return contents;
		}

		public Course_Chapter_Content GetCouserChapterContentById(int id)
		{
			Course_Chapter_Content content = context.Course_Chapter_Content.Find(id);
			return content;
		}

		public List<Course_Chapter_Content> GetChapterContentsByChapterId(int id)
		{
			List<Course_Chapter_Content> contents = context
													.Course_Chapter_Content
													.Where(p => p.course_chapter_id == id).ToList();
			return contents;
		}

		public void Add(Course_Chapter_Content content)
		{
			try
			{
				context.Course_Chapter_Content.Add(content);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Course_Chapter_Content content = context.Course_Chapter_Content.Find(id);
			try
			{
				context.Course_Chapter_Content.Remove(content);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Course_Chapter_Content content)
		{
			Course_Chapter_Content oldContent = context.Course_Chapter_Content.Find(content.id);
			try
			{
				context.Entry(oldContent).CurrentValues.SetValues(content);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
