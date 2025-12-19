using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq.Expressions;
class Operators{
    public static void Main(String []args)
    {

    // Arithmetic operators
        int a = 4;
        int b = 9;

        // add Operators
        int Sum = a + b;
        Console.WriteLine(sum);


        // substract Operators
        int Substract = a - b;
        Console.WriteLine(Substract);


        // multiplication Operators
        int Product = a * b;
        Console.WriteLine(Product);


        // Division operators
        double Division = a / b;
        Console.WriteLine(Division);


        // modulus operators
        int Mod = a % b;
        Console.WriteLine(Mod);


    // Relation operators
        
        // Compare values "=="
        bool Equal = (a == b);
        Console.WriteLine(Equal);


        // not equal "!="
        bool NotEqual = (a != b);
        Console.WriteLine(NotEqual);


        // Greater Than ">"
        bool Greater = (a > b);
        Console.WriteLine(Greater);



        // GreaterEqual Than ">="
        bool GreaterEqual = (a >= b);
        Console.WriteLine(GreaterEqual);



        // less than
        bool Less = (a < b);
        Console.WriteLine(Less);


        // lessEqual than
        bool LessEqual = (a <= b);
        Console.WriteLine(LessEqual);



    // Logical operator

        bool c = false;
        bool d = true;

        // And operator;
        bool And = (d && c);
        Console.WriteLine(And);


        // Or operator;
        bool Or = (c || d);
        Console.WriteLine(Or);


        // Not operator;
        bool Not = !d;
        Console.WriteLine(Not);



    // Assignment operators;

        int x = 9;
        int y = 7;

        // "=" operator;
        int k = x;
        Console.WriteLine(k);


        // Addition operator;
        x += y;
        Console.WriteLine(x);

        // substraction opertor
        x -= y;
        Console.WriteLine(x);

        // Multiplication opertor
        x *= y;
        Console.WriteLine(x);
        

        // Division opertor
        x /= y;
        Console.WriteLine(x);

        // Modulous opertor
        x %= y;
        Console.WriteLine(x);


    // Unary operators;

        // "+"
        x = +x;
        Console.WriteLine(x);


        // "-"
        x = -x;
        Console.WriteLine(x);


        // "++"
        x = ++x;
        Console.WriteLine(x);


        // "--"
        x = --x;
        Console.WriteLine(x);


        // "!"
        bool flip = true;
        flip = !flip;
        Console.WriteLine(flip);


    // Bitwise Operators

        int n = 4;
        int m = 5;

        // And operators
        int And = n&m;
        Console.WriteLine(And);

        // Or operators
        int Or = n|m;
        Console.WriteLine(Or);

        // Xor operators
        int Xor = n^m;
        Console.WriteLine(Xor);

        // Complement operators
        int Complement = ~m;
        Console.WriteLine(Complement);

        // Left shift operators
        int LeftShift = n << m;
        Console.WriteLine(LeftShift);

        // RightShift operators
        int RightShift = n >> m;
        Console.WriteLine(RightShift);
















    }
}