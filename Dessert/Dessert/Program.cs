using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessert
{
    //DESERT
    class Dessert
    {
        string name;
        double weight;
        int calories;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }


        public string toString()
        {
            string ispis = ("Ime: " + this.name + "\nTezina: " + this.weight + "\nKalorije: " + this.calories);
            return ispis;
        }

        public Dessert(string name, double weight, int calories)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
        }
    }
    //CAKE
    class Cake : Dessert
    {
        bool containsGluten;
        string cakeType;

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.Name = name;
            this.Weight = weight;
            this.Calories = calories;
            this.containsGluten = containsGluten;
            this.cakeType = cakeType;
        }


        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public string toString()
        {
            string cakes = ("Ime: " + this.Name + "\nTezina: " + this.Weight + "\nKalorije: " + this.Calories + "\nGluten: " + this.containsGluten + "\nTip kolača: " + this.cakeType);
            return cakes;
        }
        
        public string GetDessertType()
        {
            return "Cake";
        }
    }
    //ICE CREAM
    class IceCream : Dessert
    {
        string flavour;
        string color;
        public IceCream(string name, double weight, int calories, string flavour, string color) : base(name, weight, calories)
        {
            this.Name = name;
            this.Weight = weight;
            this.Calories = calories;
            this.flavour = flavour;
            this.color = color;
        }

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }
        public string CakeType { get; private set; }

        public string toString()
        {
            string sladoledi = ("Ime: " + this.Name + "\nTezina: " + this.Weight + "\nKalorije: " + this.Calories + "\nOkus: " + this.flavour + "\nBoja: " + this.color);
            return sladoledi;
        }
        public string GetDessertType()
        {
            return "Sladoled";
        }
    }
    //PERSON
    class Person
    {
        string name;
        string surename;
        int age;

        public string Name { get => name; set => name = value; }
        public string Surename { get => surename; set => surename = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, string surename, int age )
        {
            Name = name;
            Surename = surename;
            Age = age;
        }
        public string toString()
        {
            string osoba = ("Ime: " + this.name + "\nPrezime: " + this.surename + "\nGodine: " + this.age);
            return osoba;
        }
       
    }
    //STUDENT
    class Student : Person
    {
        string studentId;
        int academicYear;
        public Student(string name, string surename, int age, string studentId, int academicYear) : base(name, surename, age)
        {
            StudentId = studentId;
            AcademicYear = academicYear;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public int AcademicYear { get => academicYear; set => academicYear = value; }

        public string toString()
        {
            string osoba = ("Ime: " + this.Name + "\nPrezime: " + this.Surename + "\nGodine: " + this.Age + "\nID: " + this.studentId +
                "\nGodŠkolovanja: " + this.academicYear);
            return osoba;
        }
    }
    //TEACHER
    class Teacher : Person
    {
        string email;
        string subject;
        double salary;
        public Teacher(string name, string surename, int age, string email, string subject, double salary) : base(name, surename, age)
        {
            Email = email;
            Subject = subject;
            Salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }
        public string toString()
        {
            string osoba = ("Ime: " + this.Name + "\nPrezime: " + this.Surename + "\nGodine: " + this.Age + "\nEmail: " + this.email
                + "\nPredmet: " + this.subject + "\nPlaća: " + this.salary);
            return osoba;
        }
        public string increaseSalary()
        {
            int postotak = 0;

            return Convert.ToString(postotak);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dessert desert = new Dessert("Čoko", 12.5, 140);
             Console.WriteLine(desert.toString());

             Cake kolac = new Cake("Vanilla", 45.6, 776, true, "Cake");
             Console.WriteLine("- - - - -");
             Console.WriteLine(kolac.toString());

             IceCream slado = new IceCream("Ananas", 34.2, 300, "Ananas", "Žuta");
             Console.WriteLine("- - - - -");
             Console.WriteLine(slado.toString());
             Console.WriteLine("- - - - -");

             Person a = new Person("Ivo", "Ivić", 15);
             Person b = new Person("Ivo", "Ivić", 15);
             Console.WriteLine(a.toString() + "\n- - - - -" + "\n" + b.toString());
             if (string.Equals(a.Name, b.Name) == true && string.Equals(a.Surename, b.Surename) == true && string.Equals(a.Age, b.Age) == true)
             {
                 Console.WriteLine("Osobe su iste.");

             }

             Student c = new Student("Ivan", "Jakšić", 17, "57",(short)2);
             Student d = new Student("Ivan", "Burbon", 16, "57",(short)3);
             Console.WriteLine(c.toString() + d.toString());
             if(string.Equals(c.StudentId, d.StudentId) == true)
             {
                 Console.WriteLine("Isti je ID. Ista je osoba.");
             }

             Teacher e = new Teacher("Ana", "Kapetan", 37, "ana.kap@gmail.com", "Geografija", 4765.5);
             Teacher f = new Teacher("Ana", "Kapetan", 37, "ana.kap@gmail.com", "Geografija", 4765.5);
             if (string.Equals(e.Email, f.Email) == true)
             {
                 Console.WriteLine("Isti je E-mail. Ista je osoba.");
             }*/
            Teacher g = new Teacher("Ema", "Adić", 45, "email@email.com", "Matematika", 5690.0);
            Teacher h = new Teacher("Edi", "Tadić", 25, "edi@email.com", "Fizika", 2700.57);
            Teacher k = new Teacher("Amanda", "Rudi", 57, "amanda@email.com", "Hrvatski", 4090.90);

            Student l = new Student("Seni", "Andić", 12, "45", (short)2);
            Student m = new Student("Deni", "Andić", 12, "46", (short)2);

            Console.ReadKey();
        }
    }
}
