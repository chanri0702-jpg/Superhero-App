using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_282_Project.DataLayer
{
    internal class Datahandler
    {
        public Datahandler() { }

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




        public Datahandler(int id, string name, string surname, int age, string superpower, int score)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
            Superpower = superpower;
            Score = score;
        }


        List<Datahandler> studentData = new List<Datahandler>()
        {
            new Datahandler (1,"bob","joe",18,"Flight",50),
            new Datahandler (2,"Joe","soap",18,"Fat",50),
            new Datahandler (3,"Karen","Kyle",18,"Complains",50)
        };

        public List<Datahandler> StudentData { get => studentData; set => studentData = value; }




        public List<Datahandler> List() // --- method to read data from save file
        {

            return StudentData;
        }





    }
}
