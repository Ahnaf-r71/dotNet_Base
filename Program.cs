using System;
using System.Security.Cryptography.X509Certificates; // better practice when it comes to accessing members of different class 
// by default system class is inaugarated
class Test{
    public static void Main(string[] args){
        Console.Write("this prints line without newline");
        string fullName="Ahnaf Rashid";
        System.Console.WriteLine("\nTest");
        Console.WriteLine("\"Hello world!\""+fullName); 
        const string familyName="Rashid";
        Console.WriteLine("My family name is "+familyName);
        
        // type casting
        double salary = 11.99;
        int intSalary = (int)salary;//to cast
        Console.WriteLine("Salary as integer: "+intSalary);
        string storeString= Convert.ToString(intSalary);
        long toInt = Convert.ToInt64(salary);// need to store in a type safe int var , incase of ToInt64 need to store in long instead of int);
        Console.WriteLine(toInt);
        Console.WriteLine("Salary as string: "+storeString);
        string salary2="11"; 
        int store=int.Parse(salary2); //parse to convert from a string
        Console.Write(store);

        bool isSuccess=int.TryParse(salary2,out int result);
        Console.Write("\n"+result,isSuccess);
        Console.WriteLine($"True or False is={isSuccess}");
        const string universityName="IUB";//const must have a value asigned first
        // universityName="fault";
        
        System.Console.WriteLine(universityName);
        string var2,var3;
        char var1;
        Console.ReadLine();

        int num=5;
        var1=Convert.ToChar(num);
// oppoiste fof f"" in python is $"" in csharp

int num1=5,num2=5;
int result2=0;
        Console.WriteLine("{0}+{1}={2}",num1,num2,result2); //cant use x,y,z
        double num4=13/9;
        Console.WriteLine("Num is"+num4.ToString("F3")); //ToString("F3") for printing upto decimal
        

    }
}

// continue from 15