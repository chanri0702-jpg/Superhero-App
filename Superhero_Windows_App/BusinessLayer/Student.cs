using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG_282_Project.DataLayer;
using PRG_282_Project.PresentationLayer;

namespace PRG_282_Project.DataLayer
{
    internal class Student
    {
        public Student() { }

        int id;
        string name;
        string surname;
        int age;
        string superpower;
        int score;


        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Superpower { get => superpower; set => superpower = value; }
        public int Score { get => score; set => score = value; }




        public Student(int id, string name, string surname, int age, string superpower, int score)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
            Superpower = superpower;
            Score = score;
        }


        List<Student> studentData = new List<Student>()
        {
            new Student (1,"bob","joe",18,"Flight",50),
            new Student (2,"Joe","soap",18,"Fat",50),
            new Student (3,"Karen","Kyle",18,"Complains",50)
        };

        public List<Student> StudentData { get => studentData; set => studentData = value; }




        public List<Student> List() // --- method to read data from save file
        {
            
            return StudentData;
        }


    }
}
