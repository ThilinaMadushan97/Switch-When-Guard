var peoples = new List<Person>
{
    new ("Thilina" ,"Madushan", 16),
    new ("Saman" ,"Kumara", 56),
    new ("Asela" ,"Gunarathne", 17),
    new ("Sanath" ,"Jayasooriya", 60),

};
string CheckPerson(Person person)
{
    return person switch
    {
        {Age: var age} when age > 18 => "Adult person",
        _ => "Minor person"
    };
}

foreach (var p in peoples)
{
    Console.WriteLine(CheckPerson(p));
}
record Person(string Fname, string Lname, int Age);
