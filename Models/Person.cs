using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Interfaces;
using entregable_04.Enums;

namespace entregable_04.Models
{
    public class Person : IPerson
    {
        //Attributes
        protected Guid id { get; set; }
        protected string? name { get; set; }
        protected string? lastName { get; set; }
        protected TypeDocument documentType { get; set; }
        protected string? numberDocument { get; set; }
        protected DateOnly birthDate { get; set; }
        protected string? email { get; set; }
        protected string? phoneNumber { get; set; }
        

        //Constructor
        public Person(string name, string lastName, TypeDocument documentType, string? numberDocument, DateOnly birthDate, string? email, string? phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            DocumentType = documentType;
            NumberDocument = numberDocument;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //Properties GETTERS AND SETTERS
        public Guid Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public TypeDocument DocumentType { get => documentType; set => documentType = value; }
        public string? NumberDocument { get => numberDocument; set => numberDocument = value; }
        public DateOnly BirthDate { get => birthDate; set => birthDate = value; }
        public string? Email { get => email; set => email = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        //Methods
        // ToString
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Name} {LastName}, Tipo Documento: {DocumentType}, Documento: {NumberDocument}, Fecha de Nacimiento: {BirthDate}, Correo: {Email}, Teléfono: {PhoneNumber}";
        }

        public int CalculateAge()
        {
            return 0;
        }
    }
}