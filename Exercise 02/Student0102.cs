using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    public class Student0102
    {
        //Properties
        private int iD;
        private string fullName;
        private int year;
        private int mark1;
        private int mark2;
        private int mark3;
        //Constructors
        public Student0102()
        {

        }
        public Student0102(int iD,string fullName,int year,int mark1,int mark2,int mark3)
        {
            this.iD = iD;
            this.fullName = fullName;
            this.year = year;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public int Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public int Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }
        //Methods
        public void inputInfor()
        {
            Console.WriteLine("Input ID of the student: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Full name of the student: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Input the year of birth for the student: ");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the First mark: ");
            Mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second mark: ");
            Mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Third mark: ");
            Mark3 = int.Parse(Console.ReadLine());
        }
        public void displayInfor()
        {
            Console.WriteLine("ID of the student: "+ ID);
            Console.WriteLine("Full name of the student: " + FullName);
            Console.WriteLine("Year of Birth: " + Year);
            Console.WriteLine("First mark: " + Mark1 );
            Console.WriteLine("Second mark: " + Mark2);
            Console.WriteLine("Second mark: " + Mark3);
        }
        public float calculateAverage()
        {
            return ((Mark1 + Mark2 + Mark3) / 3); 
        }
    }
}
