using System;
using System.Collections.Generic;
using System.Linq;


List<Guest> guests = GetGuests();




Table table1 = new Table("Table 1", new List<Guest> { });
Table table2 = new Table("Table 2", new List<Guest> { });


foreach (Guest guest in guests)
{
    //Get a list of strings for the occupations
    List<string> tb1Occ = table1.GuestsList.Select((t) => t.Occupation).ToList();

    //If the occupaiton is in the string List, add the guest with the same occupation to list 2
    if (tb1Occ.Contains(guest.Occupation))
    {
        table2.AddGuest(guest);
    }
    else
    {
        table1.AddGuest(guest);
    }
}
Console.WriteLine(table1.TableName);
foreach (Guest g in table1.GuestsList)
{
    Console.WriteLine($"{g.Name} ({g.Occupation}) {g.Bio}");
}

Console.WriteLine();
Console.WriteLine(table2.TableName);
foreach (Guest g in table2.GuestsList)
{
    Console.WriteLine($"{g.Name} ({g.Occupation}) {g.Bio}");
}



//A function to make and return a list of guests
List<Guest> GetGuests()
{

    //Make a list of Guest Objects
    List<Guest> guests = new List<Guest>
    {
        new Guest {
            Name = "Marilyn Monroe",
            Occupation = "Entertainer",
            Bio = "(1926 - 1962) American actress, singer, model"
        },
        new Guest {
            Name = "Abraham Lincoln",
            Occupation = "Politician",
            Bio = "(1809 - 1865) US President during American civil war"
        },
        new Guest {
            Name = "Martin Luther King",
            Occupation = "Activist",
            Bio = "(1929 - 1968)  American civil rights campaigner"
        },
        new Guest {
            Name = "Rosa Parks",
            Occupation = "Activist",
            Bio = "(1913 - 2005)  American civil rights activist"
        },
        new Guest {
            Name = "Peter Sellers",
            Occupation = "Entertainer",
            Bio = "(1925 - 1980) British actor and comedian"
        },
        new Guest {
            Name = "Alan Turing",
            Occupation = "Computer Scientist",
            Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new Guest {
            Name = "Admiral Grace Hopper",
            Occupation = "Computer Scientist",
            Bio = "(1906-1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new Guest {
            Name = "Indira Gandhi",
            Occupation = "Politician",
            Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
        }
    };
    return guests;
}


public class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }

}

public class Table
{
    public string TableName { get; set; }
    public List<Guest> GuestsList { get; set; }

    public Table(string name, List<Guest> guests)
    {
        TableName = name;
        GuestsList = guests;
    }


    //Method to add a guest to the guest list
    public void AddGuest(Guest guest)
    {
        GuestsList.Add(guest);
    }
}



