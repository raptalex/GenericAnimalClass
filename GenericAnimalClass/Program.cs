class Animal<T>
{
    private T data;

    public Animal(T data)
    {
        this.data = data;
    }
    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    public static void Main()
    {
        Animal<string> animalName = new Animal<string>("Turkey");
        Animal<string> animalHabitat = new Animal<string>("Forest");
        Animal<bool> endangered = new Animal<bool>(false);
        Animal<bool> extinct = new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(5);

        Console.WriteLine("This animal is a {0}.", animalName.getAnimal());
        Console.WriteLine("It lives in a {0}.", animalHabitat.getAnimal());
        Console.WriteLine("Is this animal endangered? {0}.", endangered.getAnimal() ? "Yes" : "No");
        Console.WriteLine("Is this animal extinct? {0}.", extinct.getAnimal() ? "Yes" : "No");
        Console.WriteLine("This animal lives for about {0} years.", averageLifespan.getAnimal());
    }
}