namespace lesson_1;

public class Person
{
    private static int _globalId;
    private string Name { get; init; }
    private DateOnly BirthDate { get; init; }
    public Person? ParentPerson { get; set; }
    private Person? Partner { get; set; }
    private List<Person> LpPersons { get; set; } = new List<Person>();
    private EnumGender Gender { get; init; }
    public int LocalId { get; init; }

    public Person(string name, DateOnly birthDate, EnumGender gender)
    {
        Name = name;
        BirthDate = birthDate;
        Gender = gender;
        LocalId = _globalId++;
    }

    public override string ToString()
    {
        var rGender = Gender == EnumGender.Male ? "М" : "Ж";
        return $"{Name}, {rGender}, {BirthDate} -> {Partner?.Name} {Partner?.BirthDate}";
    }

    //соединение партнеров
    public void SetPartner(Person partner)
    {
        Partner = partner;
        partner.Partner = this;
        partner.LpPersons = LpPersons;
    }

    //Добавление детей
    public void AddChild(Person person)
    {
        LpPersons.Add(person);
        person.ParentPerson = this;
    }

    //печать дерева
    public void PrintChilds(int indent = 0)
    {
        if (indent == 0)
        {
            Console.WriteLine(this);
        }

        foreach (var ch in LpPersons)
        {
            if (ch.LpPersons.Count > 0)
            {
                var tmp = new String(' ', indent + 5);
                Console.WriteLine(string.Concat(tmp, ch));
                ch.PrintChilds(indent + 5);
            }
            else
            {
                var tmp = new String(' ', indent + 5);
                Console.WriteLine(string.Concat(tmp, ch));
            }
        }
    }
}