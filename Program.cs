namespace lesson_1;

public class Program
{
    private static void Main()

    {
        // создаем
        var person1 = new Person("Василий", DateOnly.Parse("10.12.1945"), EnumGender.Male);
        var person2 = new Person("Екатерина", DateOnly.Parse("21.08.1957"), EnumGender.Female);
        var person3 = new Person("Евгений", DateOnly.Parse("10.12.1965"), EnumGender.Male);
        var person4 = new Person("Люся", DateOnly.Parse("21.08.1977"), EnumGender.Female);
        var person5 = new Person("Людмила", DateOnly.Parse("13.05.1978"), EnumGender.Female);
        var person6 = new Person("Света", DateOnly.Parse("27.02.1995"), EnumGender.Female);
        var person7 = new Person("Леонид", DateOnly.Parse("21.08.2007"), EnumGender.Male);
        var person8 = new Person("Несмышленыш", DateOnly.Parse("21.08.2021"), EnumGender.Male);
        // женим
        person1.SetPartner(person2);
        person3.SetPartner(person5);
        // добавляем детей
        person3.AddChild(person6);
        person3.AddChild(person7);
        person1.AddChild(person3);
        person1.AddChild(person4);
        person7.AddChild(person8);
        // печатаем дерево для person1 
        person1.PrintChilds();
    }
}