

class Cliente
{
    private string name = "Default";
    public string Name {
        get => name;
        set {
            for (int i = 0; i < value.Length; i++) {
                char charAtual = value[i];
                if (char.IsNumber(charAtual)) {
                    Console.WriteLine("nome inválido");
                    return;
                }
            }
            name = value
        }
    }
}


class Exec
{
    public static void Main(string[] args)
    {
        Cliente obj = new Cliente();
        obj.Name = "6641adda";
        Console.WriteLine(obj.Name);
        obj.Name = "Brenda";
        Console.WriteLine(obj.Name);
    }
}