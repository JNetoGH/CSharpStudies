
class Dog
{
    public string nome;
    public string raca;
    public int idade;
    public int altura;

    // Construtor
    public Dog(string nomeParam, int idadeParam, string racaParam, int alturaParam)
    {
        nome = nomeParam;
        raca = racaParam;
        idade = idadeParam;
        altura = alturaParam;
    }
    
    public void latir() => Console.WriteLine(idade >= 10 ? "auauuuha auashuda" : "au au");
    public string PegarResumo() => $"Nome: {nome} \nIdade: {idade} \nRaça: {raca} \nAltura: {altura}";
}


class MyClass
{

    static void Method(string nome, int idade, string raca, int altura)
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade1: " + idade);
        Console.WriteLine("Raça1: " + raca);
        Console.WriteLine("Raça1: " + altura);
    }
    
    public static void Main(string[] args)
    {
        
        Console.WriteLine();

        int a = 10;
        int b = a;
        b = 5;
        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine("\n");
        
        Dog dog1 = new Dog("Marley", 10, "labrador", 30);
        Dog dog2 = dog1;
        dog2.nome = "Rodolfo";
        Console.WriteLine(dog1.PegarResumo());
        Console.WriteLine();
        Console.WriteLine(dog2.PegarResumo());
        Console.WriteLine();

        /*
        Console.WriteLine();
        
        int idade1 = 12;
        string raca1 = "pit";
        string nome1 = "Leo";
        int altura1 = 13;
        Method(nome1, idade1, raca1, altura1);
        if (idade1 >= 10) Console.WriteLine("auauuuha auashuda");
        else Console.WriteLine("au au");
        
        Console.WriteLine();
        
        int idade2 = 3;
        string raca2 = "boxer";
        string nome2 = "Juca";
        int altura2 = 15;
        Method(nome2, idade2, raca2, altura2);
        if (idade2 >= 10) Console.WriteLine("auauuuha auashuda");
        else Console.WriteLine("au au");

        Console.WriteLine();
        
        int idade3 = 5;
        string raca3 = "Golden";
        string nome3 = "Jose";
        int altura3 = 23;
        Method(nome3, idade3, raca3, altura3);
        if (idade2 >= 10) Console.WriteLine("auauuuha auashuda");
        else Console.WriteLine("au au");

        if (idade1 >= 10) Console.WriteLine("auauuuha auashuda");
        if (idade2 >= 10) Console.WriteLine("auauuuha auashuda");
        if (idade2 >= 10) Console.WriteLine("auauuuha auashuda");
        
        Console.WriteLine("\n\n\n");
        //----------------------------------------------------------------

        

        Dog d1 = new Dog("Marley", 10, "labrador", 30); 
        Console.WriteLine();
        
        Dog d2 = new Dog("Beto", 2, "rusk", 25);
        Dog d3 = new Dog("Rafael", 4, "Chiaua", 10);
      

        Console.WriteLine();
        
        */
    }
}
