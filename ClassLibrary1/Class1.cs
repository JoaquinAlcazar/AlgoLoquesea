using System.Runtime.CompilerServices;

namespace library
{
    public class employee
    {
        protected DateOnly birthDate { get; set; }

        public employee(DateOnly _birthdate) {
            this.birthDate = _birthdate;
        }
        public int countage() 
        {
            return 2024 - this.birthDate.Year;
        }
        
    }
}
