using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class CourseRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Course> GetAllCourses()
		{
			List<Course> courses = context.Courses.ToList();
			return courses;
		}

		public Course GetCourseById(int id)
		{
			Course course = context.Courses.Find(id);
			return course;
		}

		public List<Course> GetCourseByTeacher(int id)
		{
			List <Course> courses = context.Courses.Where(p => p.tutor_id == id).ToList();
			return courses;
		}

		public List<Course> GetTeachersByCourseId(int id)
		{
			List<Course> courses = context.Courses.Where(p => p.id == id).ToList();
			return courses;
		}

		public void Add(Course course)
		{
			try
			{
				context.Courses.Add(course);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Course course = context.Courses.Find(id);
			try
			{
				context.Courses.Remove(course);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Course course)
		{
			Course oldCourse = context.Courses.Find(course.id);
			try
			{
				context.Entry(oldCourse).CurrentValues.SetValues(course);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
