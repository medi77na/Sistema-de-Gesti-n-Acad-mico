using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Enums;

namespace entregable_04.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        TypeDocument DocumentType { get; set; }
        string NumberDocument { get; set; }
        DateOnly BirthDate { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        int CalculateAge();
    }
}