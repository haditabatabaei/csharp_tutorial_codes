using System;
namespace person {
    public class Person {
        public string firstName {get;set;}
        public string lastName {get; set;}
        public string id {get; set;}

        public string address {get; set;}

        public string toString() {
            return "#" + id + " " + firstName + " " + lastName;
        }

        public void print() {
            Console.WriteLine(toString());
        }
    }
}