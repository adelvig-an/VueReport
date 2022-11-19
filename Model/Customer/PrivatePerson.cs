using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Customer
{
    public class PrivatePerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; //Имя
        public string LastName { get; set; } = null!; //Фамилия
        public string Patronymic { get; set; } = null!; //Отчество
    }
}
