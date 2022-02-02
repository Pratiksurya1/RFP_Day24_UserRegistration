using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_UserRegistration
{
    internal class ValidatorException:Exception
    {
        public enum ExcetionType
        {
            Invalid_FirstName_Exceotion,
            Invalid_LastName_Exceotion,
            Invalid_EmailID_Exceotion,
            Invalid_MobileNumber_Exceotion,
            Invalid_Password_Exceotion

        }

        private ExcetionType type;
        public ValidatorException(ExcetionType type,String massage) : base(massage)
        {
            this.type=type;
        }
    }
}
