using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class CourseChapterRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Course_Chapter> GetAllCourseChapters()
		{
			List<Course_Chapter> chapters = context.Course_Chapter.ToList();
			return chapters;
		}

		public Course_Chapter GetCourseChapterById(int id)
		{
			Course_Chapter chapter = context.Course_Chapter.Find(id);
			return chapter;
		}

		public List<Course_Chapter> GetCourseChaptersByCourseId(int id)
		{
			List<Course_Chapter> chapters = context.Course_Chapter
												.Where(p=> p.course_id == id).ToList();
			return chapters;
		}

		public void Add(Course_Chapter chapter)
		{
			try
			{
				context.Course_Chapter.Add(chapter);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Course_Chapter chapter = context.Course_Chapter.Find(id);
			try
			{
				context.Course_Chapter.Remove(chapter);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Course_Chapter chapter)
		{
			Course_Chapter oldChapter = context.Course_Chapter.Find(chapter.id);
			try
			{
				context.Entry(oldChapter).CurrentValues.SetValues(chapter);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
