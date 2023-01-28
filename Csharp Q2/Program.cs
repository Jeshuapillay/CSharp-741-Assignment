class Program{
    public static void Main(string[] args){
        
       Console.WriteLine("Welcome To The Grade Result:");

       Console.WriteLine("Test1" + "     " + "Test2" + "     " + "Test3");

       int[] Tests = new int[2];

       Console.WriteLine("Enter marks: ");
       
       for(int i = 0; i < 10; i++){
           Tests[i] = Convert.ToInt32(Console.ReadLine());
       }

       for(int j = 0; j < 10; j++){
           Console.WriteLine(Tests[j]);
       }

    }

}