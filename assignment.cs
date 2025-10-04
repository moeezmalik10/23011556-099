using System;
class evenodd {
  public static void program() {
    Console.WriteLine("Enter Number");
    int a = int.Parse(Console.ReadLine());
    if( a % 2 == 0){
    Console.WriteLine("Number is Even");    
}
    else{ 
    Console.WriteLine("Number is Odd");
    }
    }
  }
 class calculater{
    public static void Run(){
        Console.WriteLine("Basic Calculater \n Enter Option \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
        int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            int ab = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int ac = int.Parse(Console.ReadLine());
        switch(b){
            case 1:
                int c = ab + ac;
                Console.WriteLine("Result: " + c);
                break;
            case 2:
                int d = ab - ac;
                Console.WriteLine("Result: " + d);
                break;
            case 3:
                int e = ab * ac;
                Console.WriteLine("Result: " + e);
                break;
            case 4:
                int f= ab / ac;
                Console.WriteLine("Result: " + f);
                break;
        }
        
    }
 }
 class grade{
    public static void grading(){
        Console.WriteLine("Grade Check \n Enter Marks");
        int x = int.Parse(Console.ReadLine());
        if (x > 85){
            Console.WriteLine("Grade A");
        }
        else if (x < 84 && x > 70){
            Console.WriteLine("Grade B");
        }
        else if (x < 69 && x > 55){
            Console.WriteLine("Grade C");
        }
        else if (x < 54 && x > 40){
            Console.WriteLine("Grade D");
        }
        else 
            Console.WriteLine("Grade F");
    }
 }
 class natural{
    public static void sum(){
        int n=0;
        Console.WriteLine("Sum of Natural Number\n Enter Number");
        int z= int.Parse(Console.ReadLine());
        for(int i=1; i<= z; i++){
            n = n + i;
        }
        Console.WriteLine("Result " + n);
    }
 }
 class table{
    public static void tab(){
        Console.WriteLine("Table \n Enter Number you want table:");
        int y = int.Parse(Console.ReadLine());
        for (int s=1 ; s<=10; s++)
        {
            Console.WriteLine(y + "*" + s + "=" + s*y);
        }
    }
 }
 class factorial{
    public static void fact(){
         int n=1;
        Console.WriteLine("Factorial\n Enter Number");
        int z= int.Parse(Console.ReadLine());
        int i=1;
        while (i<=z)
        {
            n= n*i;
            i++;
        }
        Console.WriteLine("Result " + n);
    }
 }
  class reverse{
     public static void reve(){
       Console.WriteLine("Reverse Number \n Enter Number");
       int z= int.Parse(Console.ReadLine());
       int rev=0;
       while (z>0){
           rev = rev * 10 + z % 10;
           z/=10;
       }
       Console.WriteLine($"Reverse Number : {rev}");
     }
 }
 class assignment{
  static void Main(){
    evenodd.program();
    calculater.Run();
    grade.grading();
    natural.sum();
    table.tab();
    factorial.fact();
    reverse.reve();
    }
 }
 
