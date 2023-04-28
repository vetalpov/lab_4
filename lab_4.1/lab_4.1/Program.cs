class Bird
{
    public string Name { get; set; }
    public Bird(string name)
    {
        Name = name;
    }
    public virtual void Fly()
    {
        Console.WriteLine($"{Name} лiтає");
    }

    public virtual void Sing()
    {
        Console.WriteLine($"{Name} спiває");
    }

    public virtual void LayEggs()
    {
        Console.WriteLine($"{Name} несе яйця");
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Bird bird = (Bird)obj;
        return true;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

class Cuckoo : Bird
{
    public Cuckoo(string name) : base(name)
    {
    }
    public override void Sing()
    {
        Console.WriteLine($"{Name} кукує");
    }
}

class Chiken : Bird
{
    public Chiken(string name) : base(name)
    {
    }

    public void HatchChickens()
    {
        Console.WriteLine($"{Name} висиджує пташенят");
    }
}

class Kvochka : Chiken
{
    public Kvochka(string name) : base(name)
    {
    }
    public override void Fly()
    {
        Console.WriteLine($"{Name}  не може літати");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird("Пташка");
        bird.Fly();
        bird.Sing();
        bird.LayEggs();

        Console.WriteLine("");

        Cuckoo cuchoo = new Cuckoo("Зозуля");
        cuchoo.Sing();
        cuchoo.LayEggs();
        cuchoo.Fly();

        Console.WriteLine("");

        Chiken chicken = new Chiken("Курка");
        chicken.Sing();
        chicken.LayEggs();
        chicken.HatchChickens();

        Console.WriteLine("");

        Kvochka kvoch = new Kvochka("Квочка");
        kvoch.Fly();
        kvoch.Sing();

        Console.ReadKey();

    }
}