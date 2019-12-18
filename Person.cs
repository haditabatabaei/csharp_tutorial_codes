namespace csharp_person{
class Person  {
        public string id;
        public int age;
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName, string id, int age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.age = age;
        }
    }
}
