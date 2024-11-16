using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankProjectClientSidev2.Classes
{
    public class clsValidations
    {
        public enum enCheckState { eEmptyCheck = 0, eValidation = 1 };
        public static enCheckState CheckState;

        public static bool CheckEmptyField(string Content)
        {
            return Content == "";
        }

        public static bool CheckPasswordContainNumbers(string Password)
        {
            return Regex.IsMatch(Password, @"\d{8,}");
        }

        public static bool CheckPasswordContainCapLetter(string Password)
        {
            return Regex.IsMatch(Password, @"[A-Z]");
        }
        public static bool CheckPasswordContainLowLetter(string Password)
        {
            return Regex.IsMatch(Password, @"[a-z]");
        }

        public static bool CheckPasswordContainSymbols(string Password)
        {
            return Regex.IsMatch(Password, @"[\W_]{3,}");
        }

        public static bool VerifyPasswordConditions(string Password)
        {
            if (!CheckPasswordContainNumbers(Password))
                return false;

            if (!CheckPasswordContainCapLetter(Password))
                return false;

            if (!CheckPasswordContainLowLetter(Password))
                return false;

            if (!CheckPasswordContainSymbols(Password))
                return false;

            return true;
        }

    }
}
