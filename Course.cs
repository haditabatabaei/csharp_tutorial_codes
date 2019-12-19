using System;
namespace course {
    public class Course {
        public string personId;
        public int score;


        public void print(){
            Console.WriteLine(toString());
        }

        public string toString() {
            return "personId #" + personId + " mark " + score;
        }
    }
}