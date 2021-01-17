using System;

namespace SMService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentService : IStudentService
    {
        public CompositeType AddNewStudent(CompositeType student)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetStudentList(CompositeType students)
        {
            throw new NotImplementedException();
        }

        public CompositeType UpdateStudentInfo(CompositeType student)
        {
            throw new NotImplementedException();
        }

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

    }
}
