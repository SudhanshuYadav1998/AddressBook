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
                 Contact_num = 487665776 },
         new person
                {
                    First_Name = "Sunil ",
                    Last_Name = "Sharma ",
                    Address = "East-Patel-Nagar ",
                    City = "Delhi ",
                    State = "New Delhi ",
                    Email = "sunil@xyz ",
                    zip = 1100812,
                    Contact_num = 1287665776
                },
          new person
                {
                    First_Name = "himanshu ",
                    Last_Name = "Yadav ",
                    Address = "pitampura ",
                    City = "Delhi ",
                    State = "Old Delhi ",
                    Email = "abc@xyz ",
                    zip = 110008,
                    Contact_num = 876565776
                },

        };
        //iterate the student by selecting the student Who live in Delhi using Lamda Function
        IEnumerable<person> Query = Person.Where(s => s.City.Equals("Delhi "));
        IEnumerable<person> Query1 = Person.Where(s => s.State.Equals("New Delhi "));

        foreach (person e in Query1)
        {
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine("***************************");
        foreach (person e in Query)
        {
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine("***************************");
        //to check the number of entry in a list
        Console.WriteLine($"{Person.Count} person are there in the list");
    }
}