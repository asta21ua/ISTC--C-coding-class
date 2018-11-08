﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksStageSecond
{/// <summary>
 /// 1.Սահմանել մարդ class -ը որի մեջ լինի հետևյալ field-ները Անուն Ազգանուն Տարիք Քաշ Սեռ:
 /// 2.Որտեղ բոլորը հասանաելի չեն դրսից (private են) և կարող է կատարել հետևյալ գործողությունները`
 ///   ա.Առանձին մեթոդներով տպել բորլոր վերը թվարկածները: 
 ///    բ.Առանձին մեթոդներով փոփոխել վերը թվարկածները: 
 /// 5. Class-ը պետք է ունենա կոնստրուկտոր, որը ինիցիալիզացնի բոլոր վերը նշված field-ները:
 /// </summary>


    public class Human //Creating public class Human with following  private fields: GivenName, FamilyName,Gender, Age, Weigth and Heigth 
    {
        private string GivenName;
        private string FamilyName;
        private string Gender;
        private int Age;
        private float Weight;
        private float Height;

        public Human(string givenName, string familyName, string gender, int age, float weight, float height)
        {

            this.GivenName = givenName;
            this.FamilyName = familyName;
            this.Gender = gender;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }


        class Program // Printing each parameter in with different methods
        {

            static void Main(string[] args)
            {

                var human1 = new Human("Elizabeth", "Black", "female", 24, 68, 165);
                var human2 = new Human("Tom", "Smith", "male", 19, 75, 172);

                Console.WriteLine(human1);
                Console.WriteLine(human2);

                Console.ReadKey();

            }
        }
    }

}