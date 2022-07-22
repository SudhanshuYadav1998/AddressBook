class person
{
    //  Variable Decleration
    public string First_Name;
    public string Last_Name;
    public string Address;
    public string City;
    public string State;
    public string Email;
    public string zip;
    public string Contact_num;

    //Main program starts from here
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Details as Follow: first_name-> last_name-> address-> city-> state-> email-> zip-> contactNumber");
        //Declare a list variable
        IEnumerable<person> Person = new List<person>()
            {
            //creating a detail of two person
                new person
                {
                    First_Name = Console.ReadLine(),
                    Last_Name = Console.ReadLine(),
                    Address = Console.ReadLine(),
                    City = Console.ReadLine(),
                    State = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    zip = (Console.ReadLine()),
                    Contact_num = (Console.ReadLine())
                },

        new person
             {
                 First_Name = Console.ReadLine(),
                 Last_Name = Console.ReadLine(),
                 Address = Console.ReadLine(),
                 City = Console.ReadLine(),
                 State = Console.ReadLine(),
                 Email = Console.ReadLine(),
                 zip = Console.ReadLine(),
                 Contact_num = (Console.ReadLine()) }
        };
        foreach (var person in Person)
        {
            Console.WriteLine($" {person.First_Name} {person.Last_Name} {person.Address}" +
                $" {person.City} {person.State} {person.zip} {person.Contact_num}");
        }
        Console.WriteLine("Enter true for Edit & false for Continue");
        bool D = Convert.ToBoolean(Console.ReadLine());

        if (D == true)
        {
            Console.WriteLine("Enter Edited Details as Follow:  first_name->Edited_FirstName|| last_name->Edited_Last_Name ||address->Edited_Address" +
                " city->Edited_city|| state->Edited_State || email->Edited_Email|| zip->Edited_Zip|| contactNumber->Edited_ContactNum");
            foreach (var person in Person.Where(w => w.First_Name == Console.ReadLine()))
            {
                person.First_Name = Console.ReadLine();


                foreach (var l in Person.Where(w => w.Last_Name == Console.ReadLine()))
                {
                    l.Last_Name = Console.ReadLine();

                    foreach (var a in Person.Where(w => w.Address == Console.ReadLine()))
                    {
                        a.Address = Console.ReadLine();

                        foreach (var c in Person.Where(w => w.City == Console.ReadLine()))
                        {
                            c.City = Console.ReadLine();

                            foreach (var s in Person.Where(w => w.State == Console.ReadLine()))
                            {
                                s.State = Console.ReadLine();

                                foreach (var z in Person.Where(w => w.zip == Console.ReadLine()))
                                {
                                    z.zip = Console.ReadLine();

                                    foreach (var co in Person.Where(w => w.Contact_num == Console.ReadLine()))
                                    {
                                        co.Contact_num = Console.ReadLine();

                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var person in Person)
            {
                Console.WriteLine($" Details After Update are : {person.First_Name} {person.Last_Name} {person.Address}" +
                   $" {person.City} {person.State} {person.zip} {person.Contact_num}");
            }
        }
    }
}