using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Learning.DAL;

namespace E_Learning.Business
{
	public class EnrollmentRepository
	{
		public ELearningDB context = new ELearningDB();

		public List<Enrollment> GetAllEnrollments()
		{
			List<Enrollment> enrollments = context.Enrollments.ToList();
			return enrollments;
		}

		public Enrollment GetEnrollmentById(int id)
		{
			Enrollment enrollment = context.Enrollments.Find(id);
			return enrollment;
		}

		public List<Enrollment> GetEnrolmentsByCourseId(int courseId)
		{
			List<Enrollment> enrolments = context.Enrollments.Where(p => p.course_id == courseId).ToList();
			return enrolments;
		}

		public void Add(Enrollment enrollment)
		{
			try
			{
				context.Enrollments.Add(enrollment);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			Enrollment enrollement = context.Enrollments.Find(id);
			try
			{
				context.Enrollments.Remove(enrollement);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}

		public void Update(Enrollment enrollment)
		{
			Enrollment oldEnrollment = context.Enrollments.Find(enrollment.id);
			try
			{
				context.Entry(oldEnrollment).CurrentValues.SetValues(enrollment);
			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message + context.GetValidationErrors());
			}
			context.SaveChanges();
		}
	}
}
