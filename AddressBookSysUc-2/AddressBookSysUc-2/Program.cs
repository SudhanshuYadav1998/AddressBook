    class person
    {
    //  Variable Decleration
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public string Email;
        public int zip;
        public int Contact_num;
    //Get Tostring Methods That returns All the 8 variables
        public override string ToString()
        {
            return First_Name + " " + Last_Name + " " + Address + " " + City + " " + State + " " + Email + " " + 
                zip + " " + Contact_num;
        }
    //Main program starts from here
    private static void Main(string[] args)
        {
        //Declare a list variable
        List<person> Person = new List<person>()
            {
            //creating a detail of two person
                new person
                {
                    First_Name = "Sudhanshu ",
                    Last_Name = "Yadav ",
                    Address = "West-Patel-Nagar ",
                    City = "Delhi ",
                    State = "New Delhi ",
                    Email = "abc@xyz ",
                    zip = 11008,
                    Contact_num = 87665776
                },

        new person
             {
                 First_Name = "Ankit ",
                 Last_Name = "Singh ",
                 Address = "Ramesh-Nagar ",
                 City = "Noida ",
                 State = "UP ",
                 Email = "qwerty@xyz ",
                 zip = 8930080,
                 Contact_num = 487665776 }
        };
        //iterate the student by selecting the student Whose name Starts with S using Where Function
        IEnumerable<person> Query = Person.Where(s => s.First_Name[0] == 'A');
        IEnumerable<person> Query1 = Person.Where(s => s.First_Name[0] == 'S');
        Console.WriteLine("First_Name Last_Name Address City State Email zip Contact_Num " );
            Console.WriteLine("+++++++++++++");
        foreach (person e in Query1)
        {
            Console.WriteLine(e.ToString());
        }
        foreach (person e in Query)
            {
                Console.WriteLine(e.ToString());
            }
            //to check the number of entry in a list
        Console.WriteLine("Initial count:{0} are person there in the list", Person.Count);
    }
    }