using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BUS.OtherFunctions
{
    public class InputValidate
    {
        public static bool KiemTraASCII(string input)
        {
            return Regex.IsMatch(input, @"[^\x00-\x7F]");
        }
        public static bool PhoneNumberValidate(string phoneNumber)
        {
            string pattern = @"^(0\d{9,10}|84\d{9,10}|\+84\d{9,10})$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool EmailValidate(string email)
        {
            return MailAddress.TryCreate(email, out var resultEmail);
        }

        public static bool BirthdayValidate(string birthday)
        {
            string[] dateFormats = new string[]
        {
            "dd/MM/yyyy",
            "dd/M/yyyy",
            "d/MM/yyyy",
            "d/M/yyyy",
            "dd-MM-yyyy",
            "dd-M-yyyy",
            "d-MM-yyyy",
            "d-M-yyyy",
            "yyyy/MM/dd",
            "yyyy/M/d",
            "yyyy-MM-dd",
            "yyyy-M-d"
        };
            return DateTime.TryParseExact(birthday, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime);
        }
    }
}
