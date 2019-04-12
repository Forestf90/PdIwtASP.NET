using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Forms.Models
{
    public enum ConferenceType
    {

        Lecture,
        Workshop,
        Discusion
    }
    public class ConferenceUser
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Avatar { get; set; }
        public ConferenceType ? ConferenceType { get; set; }

        //public string DisplayName(this Enum value)
        //{
        //    Type enumType = value.GetType();
        //    var enumValue = Enum.GetName(enumType, value);
        //    MemberInfo member = enumType.GetMember(enumValue)[0];

        //    var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
        //    var outString = ((DisplayAttribute)attrs[0]).Name;

        //    if (((DisplayAttribute)attrs[0]).ResourceType != null)
        //    {
        //        outString = ((DisplayAttribute)attrs[0]).GetName();
        //    }

        //    return outString;
        //}
    }
}
