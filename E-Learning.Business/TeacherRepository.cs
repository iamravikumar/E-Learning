using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;
using System.Collections;

namespace E_Learning.Business
{
	public class TeacherRepository
	{
		//this object represents the database
		public ELearningDB context = new ELearningDB();

		public List<Teacher> GetAllTeachers()
		{
			List<Teacher> teachers = context.Teachers.ToList();
			return teachers;
		}

		public Teacher GetTeacherById(int id)
		{
			Teacher teacher = context.Teachers.Find(id);
			return teacher;
		}

		public List<int> GetAllTeachersIds()
		{
			List<int> teachers = context.Students.Select(p => p.id).ToList();
			return teachers;
		}

		public void Add(Teacher teacher)
		{
			try
			{
				context.Teachers.Add(teacher);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Teacher teacher = context.Teachers.Find(id);
			try
			{
				context.Teachers.Remove(teacher);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update (Teacher teacher)
		{
			Teacher oldTeacher = context.Teachers.Find(teacher.id);
			try
			{
				context.Entry(oldTeacher).CurrentValues.SetValues(teacher);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

	}
}
