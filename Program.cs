using System;
using person;
using course;
using income;
using System.Linq;
using System.Collections.Generic;

namespace csharpLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            Person hadi = new Person();
            Person raha = new Person();
            Person ali = new Person();

            Income hadiIncome = new Income("1","100", "100" , "120");
            Income rahaIncome = new Income("3", "200" ,  "50" , "10");
            Income aliIncome = new Income("2", "50" , "500" , "10");
            




            Person[] persons = {hadi, ali, raha};
            Income[] incomes = {hadiIncome, aliIncome, rahaIncome};
            IncomeMonth[] newIncomes = {
                new IncomeMonth("1", 100, "dey"),
                new IncomeMonth("1", 100, "bahman"),
                new IncomeMonth("1", 100, "esfan"),

                new IncomeMonth("2", 85, "dey"),
                new IncomeMonth("2", 200, "bahman"),
                new IncomeMonth("2", 10, "esfan"),

                new IncomeMonth("3", 50, "dey"),
                new IncomeMonth("3", 400, "bahman"),
                new IncomeMonth("3", 10, "esfan"),
            };
            // for(int i = 0 ; i < persons.Length ; i++) {
            //     newIncomse
            // }


            var joined = persons.GroupJoin(newIncomes,
                person => person.id,
                income => income.personId,
                (person , incomeGroup) => new {name = person.firstName, sumOfIncomes = incomeGroup.ToArray().Sum(s => s.salary)
                }).Max(x => x.sumOfIncomes);

            Console.WriteLine("here " + joined);

            // newIncomes.GroupBy(income => income.personId).Select()

            // var personsList = persons.ToList();

            // persons.Where(person =>       )
            // persons.GroupJoin(incomes, person => person.id, income => income.personId, (person, income) => new {
                // id = person.id,
        
            // });






            hadi.id = "1";
            hadi.firstName = "hadi";
            hadi.lastName = "tabatabaei";
            hadi.address = "valiasr";

            ali.id = "2";
            ali.firstName = "ali";
            ali.lastName = "rezaei";
            ali.address = "kashoonak";

            raha.id = "3";
            raha.firstName = "raha";
            raha.lastName = "rahayi";
            raha.address = "valiasr39785";


            // persons.GroupJoin(incomes, )


            // var mostIncomeUser = 
















            int[] randomNumbers = {10,1,3,3,4,5,6,7,8,9};
            string[] names = {"hadi" , "alI" , "rahim" , "hadi" , "raha", "sara" , "Saeid" , "Hossein"};


            //asami ke tooshoon i voojood dare
            var namesWithI = names.Where(name => name.ToLower().Contains('i')).ToList();
            var namesStartsWithS = names.Where(name => name.ToLower().StartsWith('s')).ToList();
            var namesFinishedWithM = names.Where(name => name.ToLower().EndsWith("m") );



            Console.WriteLine("Names with i / I :");
            foreach(string name in namesWithI) {
                Console.WriteLine(name);
            }

            Console.WriteLine("Names starts with s / S :");
            foreach(string name in namesStartsWithS) {
                Console.WriteLine(name);
            }


            Console.WriteLine("Names ends with m / M :");
            foreach(string name in namesFinishedWithM) {
                Console.WriteLine(name);
            }


            // var check = randomNumbers.Where(a => a== 2).Any();
            // var check = randomNumbers.Any(a => a == 2);
            // var firstSelect = randomNumbers.Where(a => a == 3).First();
            // var firstSelect2 = randomNumbers.Where(a => a == 3).FirstOrDefault();
            
            // var firstSelect3 = randomNumbers.Where(a => a == 3).Single();
            // var firstSelect4 = randomNumbers.Where(a => a == 3).SingleOrDefault();
            

            // Console.WriteLine(firstSelect4);
            // Console.WriteLine(check);


            // List<Person> persons = new List<Person>();
            // List<Course> courses = new List<Course>();
            // List<int> scores = new List<int>();
            // Random randomGen = new Random();
            
            // for(int i = 0 ; i < 10 ; i++) {
            //     // persons[i] = ;
            //     // courses[i] = new Course();
            //     persons.Add(new Person());
            //     courses.Add(new Course());  

            //     persons[i].firstName = "First Name " + i;
            //     persons[i].lastName = "Last Name " + i;
            //     persons[i].id = i + "";

            //     courses[i].personId = i + "";
            //     courses[i].score = randomGen.Next(20);
            //     persons[i].print();
            //     courses[i].print();
            //     scores.Add(courses[i].score);
            //     // persons[i].print();
            // }


            // // var newAvg = ((from course in courses select course.score).ToList().Aggregate((a,b) => ( a * scores.FindIndex(b)  + b) / courses.FindIndex(b)));
            // // Console.WriteLine("newAvg " + newAvg);

            // // var scores = (from course in courses select course.score);

            // var joined = (from person in persons join course in courses on person.id equals course.personId select person.toString() + " | " +  course.ToString()).ToList();
            // var average = (from person in persons join course in courses on person.id equals course.personId select course.score).Average();
            // var max = (from person in persons join course in courses on person.id equals course.personId select course.score).Max();
            // var min = (from person in persons join course in courses on person.id equals course.personId select course.score).Min();
            // var sum = (from person in persons join course in courses on person.id equals course.personId select course.score).Sum();
            // var sorted =(from course in courses select course.score).OrderByDescending(a => a);

            // foreach(int score in sorted) {
            //     Console.WriteLine(score);
            // }

            // foreach(string item in joined) {
            //     // Person currentPerson = (Person)item.Person;
            //     // Console.WriteLine((Person)item.);
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("Average " + average);
            // Console.WriteLine("Max " + max);
            // Console.WriteLine("Min " + min);
            // Console.WriteLine("Sum " + sum);

            // Person hadi = new Person();
        }
    }
}
