using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>

[DataContract]
public class Student
{
    
    [DataMember]
    [DisplayName("Rollnumber")]
    public int Id { get; set; }
    [DataMember] public string Name { get; set; }
    [DataMember] public string Email { get; set; }
    
    [DataMember] public StudentGender Gender { get; set; }

    [DataMember]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    [DisplayName("Date of birth")]
    public DateTime BirthDay { get; set; }
    [DataMember] public string Introducing { get; set; }
    public enum StudentGender
    {
        Male, Female , Other
    }
}