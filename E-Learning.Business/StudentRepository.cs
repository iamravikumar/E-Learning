using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;
using System.Collections;

namespace E_Learning.Business
{
	//This class represents the entire student table. It is used to manage and control student table
	public class StudentRepository
	{

		//this object represents the database
		public ELearningDB context = new ELearningDB();

		public List<Student> GetAllStudents()
		{
			List<Student> students = context.Students.ToList();
			return students;
		}

		public Student GetAStudentById(int id)
		{
			Student student = context.Students.Find(id);
			return student;
		}

		public List<int> GetAllStudentsIds()
		{
			List<int> students = context.Students.Select(p => p.id).ToList();
			return students;
		}

		public void Add(Student student)
		{
			try
			{
				context.Students.Add(student);
				context.SaveChanges();
			}catch(Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			
		}

		public void Delete(int id)
		{
			Student student = context.Students.Find(id);
			try
			{
				context.Students.Remove(student);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Student student)
		{
			Student oldStudent = context.Students.Find(student.id);
			try
			{
				context.Entry(oldStudent).CurrentValues.SetValues(student);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
