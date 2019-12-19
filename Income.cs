using System;
namespace income {
    public class Income {
        public string personId {get; set;}

        public string deyIncome {get;set;}

        public string bahmanIncome {get; set;}

        public string esfandIncome {get; set;}
    
        public Income(string personId, string deyIncome, string bahmanIncome, string esfandIncome){
            this.personId = personId;
            this.deyIncome = deyIncome;
            this.bahmanIncome = bahmanIncome;
            this.esfandIncome = esfandIncome;
        }

        public void print() {
            Console.WriteLine(personId + " " + deyIncome +  " " + bahmanIncome + " " + esfandIncome);
        }
    }

    public class IncomeMonth { 
        public string personId;
        
        public int salary;
        public string month;

        public IncomeMonth(string personId, int salary, string month){
            this.personId = personId;
                this.salary = salary;
                this.month = month;
        }

    }

}