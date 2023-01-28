class Program{
    public static void Main(string[] args){
        
        Console.Write("Please enter amount: ");
        int input = Convert.ToInt16(Console.ReadLine());

        HalfDollars(input);
        Quarters(input);
        Dimes(input);
        Nickels(input);
    }

    public static void HalfDollars(int Amount){
        double a = Amount / .5;
        Console.WriteLine("The maximum half-dollars are: " + a);
    }

    public static void Quarters(int Amount){
        double val = Amount / 0.25;
        Console.WriteLine("The maximum Quarters are: " + val);
    }

    public static void Dimes(int Amount){
        double val = Amount / 0.1;
        Console.WriteLine("The maximum Dimes are: " + val);
    }

    public static void Nickels(int Amount){
        double val = Amount / 0.05;
        Console.WriteLine("The maximum Nickels are: " + val);
    }
}