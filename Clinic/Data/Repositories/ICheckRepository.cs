using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Model;
using ClinicProject.Data;
using ClinicProject.Data.Repositories;
using System.Text.RegularExpressions;

namespace ClinicProject.Data.Repositories
{
    public interface ICheckRepository
    {
        string CheckPeople(People people,bool EditMode);
        bool IsExistPatient(string CodeMelli,int clinicId);
        bool IsExistDoctor(string CodeMelli,int clinicId);
        bool IsExistStaff(string CodeMelli, int clinicId);
    }
    public class CheckRepository : ICheckRepository
    {
        ClinicContext context = new ClinicContext();
        public string CheckPeople(People people, bool EditMode)
        {
            string result = "";
            var regex = new Regex(@"\d{10}");
            var regexTell = new Regex(@"\d");
            string oldUsername="";
            if(EditMode)
                oldUsername = context.Peoples.Find(people.Id).Username;
            if (String.IsNullOrEmpty(people.CodeMelli)&&!EditMode) result += "کد ملی نمیتواند خالی باشد !";
            else if (people.CodeMelli.Length != 10) result += "کد ملی باید 10 رقم باشد";
            else if (!regex.IsMatch(people.CodeMelli)) result += "کد ملی باید از اعداد تشکیل شده باشد  !";
            else if (!IsValidNationalCode(people.CodeMelli) && !EditMode) result += "کد ملی معتبر نمیباشد !";
            else if (context.Peoples.SingleOrDefault(p => p.CodeMelli == people.CodeMelli && p.ClinicId == people.ClinicId) != null && !EditMode) result += "کد ملی تکراری است !";
            else if (String.IsNullOrEmpty(people.Name)) result += "نام نمیتواند خالی باشد !";
            else if (String.IsNullOrEmpty(people.Family)) result += "نام خانوادگی نمیتواند خالی باشد !";
            else if (!regexTell.IsMatch(people.Tell)) result += "تلفن باید از اعداد تشکیل شده باشد !";
            else if (String.IsNullOrEmpty(people.Username)) result += "نام کاربری نمیتواند خالی باشد !";
            else if (context.Peoples.SingleOrDefault(p => p.Username == people.Username && p.ClinicId == people.ClinicId) != null && !EditMode) result += "نام کاربری تکراری است !";
            else if (context.Peoples.Where(p => p.Username != oldUsername).SingleOrDefault(p => p.Username == people.Username && p.ClinicId == people.ClinicId) != null && EditMode) result += "نام کاربری تکراری است !";
            else if (people.Password.Length < 8) result += "رمز عبور باید بیشتر از 8 کاراکتر باشد !";
            return result;
        }

        public bool IsExistDoctor(string CodeMelli, int clinicId)
        {
            return context.Doctors.Include("People").Any(p => p.People.CodeMelli == CodeMelli && p.ClinicId == clinicId);
        }

        public bool IsExistPatient(string CodeMelli, int clinicId)
        {
            return context.Patients.Include("People").Any(p => p.People.CodeMelli == CodeMelli&&p.ClinicId==clinicId);
        }

        public bool IsExistStaff(string CodeMelli, int clinicId)
        {
            return context.Staffs.Include("People").Any(p => p.People.CodeMelli == CodeMelli && p.ClinicId == clinicId);
        }

        public Boolean IsValidNationalCode(String nationalCode)
        { 
            var allDigitEqual = new[] { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
            if (allDigitEqual.Contains(nationalCode)) return false;
            var chArray = nationalCode.ToCharArray();
            var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;
            var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            var a = Convert.ToInt32(chArray[9].ToString());

            var b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
            var c = b % 11;

            return (((c < 2) && (a == c)) || ((c >= 2) && ((11 - c) == a)));
        }
    }
}
