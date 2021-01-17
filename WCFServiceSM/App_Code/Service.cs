using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    

	public MyDbContext db = new MyDbContext();
    public Student Add(Student student)
    {
        db.Students.Add(student);
        db.SaveChanges();
        return student;
    }

    public List<Student> GetStudents()
    {
        return db.Students.ToList();
    }

    public Student Edit(int? id)
    {
		return db.Students.Find(id);
	}

    public Student Update(Student student)
    {
		db.Entry(student).State = EntityState.Modified;
		db.SaveChanges();
		return student;
	}
}
