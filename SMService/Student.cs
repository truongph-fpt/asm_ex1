using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SMService
{
    [DataContract]
    class Student
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public SexualEnum Sexual { get; set; }
        [DataMember] public decimal StudentCode { get; set; }
        [DataMember] public DateTime BirthDay { get; set; }
        [DataMember] public string Description { get; set; }
        public enum SexualEnum
        {
            Male,Female
        }
    }
}
