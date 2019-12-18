using System;
using System.Globalization;
using factory;
using System.Collections.Generic;
using System.Linq;
using csharp_course;
using csharp_person;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[10];

            Random random = new Random();

            for(int i = 0; i < randomNumbers.Length ; i++) {
                randomNumbers[i] = random.Next(10);
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine("----------------");
            //query using LINQ

            var listAscending = (from n in randomNumbers where n >= 5 orderby n ascending select n).ToList();
            var listDescending = (from n in randomNumbers where n >= 5 orderby n descending select n).ToList();
            var numberOfTwos = (from n in randomNumbers where n == 2 select n).Count(); 

            foreach(int item in listAscending) {
                Console.WriteLine(item);
            }
            Console.WriteLine("numebr of 2's :" + numberOfTwos);




            Person hadi = new Person("hadi","tabatabaei", "1", 20);
            Person elahe = new Person("elahe" , "dastan" , "2" , 21);
            Person sina = new Person("sina" , "ahmadkhani" , "3" , 18);

            List<Person> persons = new List<Person>();
            persons.Add(hadi);
            persons.Add(elahe);
            persons.Add(sina);


            Course hadiCouses = new Course("1", 20,20,20);
            Course elaheCourses = new Course("2" , 18 , 17, 16);
            Course sinaCourses = new Course("3", 15, 14 , 17);

            List<Course> courses = new List<Course>();
            courses.Add(hadiCouses);
            courses.Add(elaheCourses);
            courses.Add(sinaCourses);

            // using (var context = new DataClasses1DataContex()) {

            // }

            var innerJoinQuery = (from person in persons join course in courses on person.id equals course.pid select person.firstName + " " + person.lastName + " " + course.javaScore + " " + course.csharpScore + " " + course.cppScore);
                
                foreach(string result in innerJoinQuery) {
                    Console.WriteLine(result);
                }

            var average = (from person in persons join course in courses on person.id equals course.pid select person.id + " " + course.pid);  

            // var averageGroups = ().ToList();

              



            // list.Sort((emp1,emp2) => emp1 > emp2 );
            Convert.ToInt32(Console.ReadLine()).splitMe();
            PersianCalendar persianCalendar = DateTime.Now.makeMeJalali();
            Console.WriteLine("hadi".toFarsi());
            Console.WriteLine("ali".toFarsi());

            BMW bmw = new BMW(200,2,1000,6);
            Pride pride = new Pride(20, 4, 300, 8);
            
            Console.WriteLine(bmw.toString());
            bmw.speed = 250;
            Console.WriteLine(bmw.toString());
            Console.WriteLine(pride.toString());
            pride.horsePower = pride.horsePower * 2;
            Console.WriteLine(pride.toString());

            IFacotry car = new BMW(100,100,100,100);

            // List<int> list = new List<int>();
            // list.Add(1);
            // list.Add(2);
            IEnumerable<int> ielist = new List<int>();
        }
    }

    static class NumberSplitter {

        public static void splitMe(this int inputNumber) {
            Console.WriteLine(inputNumber.ToString("N0"));
        }

        public static PersianCalendar makeMeJalali(this DateTime dateTime) {
            PersianCalendar persianCalendar = new PersianCalendar();
            persianCalendar.GetYear(dateTime);
            persianCalendar.GetMonth(dateTime);
            persianCalendar.GetDayOfMonth(dateTime);
            persianCalendar.GetDayOfWeek(dateTime);
            persianCalendar.GetDayOfYear(dateTime);
            return persianCalendar;
        }

        public static string toFarsi(this string englishName) {
            if(englishName == "hadi") {
                return "هادی";
            } else return "تعریف نشده :)";
        }
    }

}
