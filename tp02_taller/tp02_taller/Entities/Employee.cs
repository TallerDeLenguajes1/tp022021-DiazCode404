using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp02_taller.Entities
{
    public enum puestos
    {
        vendedor,
        cajero,
        encargado,
        chofer
    }
    public class Employee
    {
        //datos que el usuario debe ingresar por teclado
        private string name;
        private string lastname;
        private string dni;
        private string addres;
        private string job;
        private DateTime birthday;
        private DateTime entryCompany;
        
        //datos que voy a 
        private string antiquity;
        private string age;
        private string salary;

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Addres { get => addres; set => addres = value; }
        public string Job { get => job; set => job = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime EntryCompany { get => entryCompany; set => entryCompany = value; }

        public string Antiquity { get => antiquity; set => antiquity = value; }
        public string Age { get => age; set => age = value; }
        public string Salary { get => salary; set => salary = value; }


        public Employee(string name, string lastname, string dni, string addres, string job, DateTime birthday, DateTime entryCompany)
        {
            this.name = name;
            this.lastname = lastname;
            this.dni = dni;
            this.addres = addres;
            this.job = job;
            this.birthday = birthday;
            this.entryCompany = entryCompany;

            this.Antiquity = (DateTime.Today.AddTicks(-entryCompany.Ticks).Year - 1).ToString();
            this.Age = (DateTime.Today.AddTicks(-birthday.Ticks).Year - 1).ToString();

            this.Salary = CalculateSalary(Job);
        }
        
        public string CalculateSalary(string job)
        {
            int basic;
            switch (Job)
            {
                case "vendedor":
                    basic = 50000;
            }
        }

    }

    

    
}
