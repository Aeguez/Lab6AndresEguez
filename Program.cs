using System; 

public class Program 
{ 

public static void Main (String[] args) 
    { 
        bool done = false; 

    while (!done) { 
            Console.WriteLine("Which function you want to call?"); 
            Console.WriteLine("1: Stack with no parameters"); 
            Console.WriteLine("2: Stack with parameters"); 
            Console.WriteLine("3: Stack with heap"); 
            Console.WriteLine("4: Stack Over"); 
            Console.WriteLine("5: Exit"); 
            Console.Write("Your choice: "); 
            int opCode = int.Parse(Console.ReadLine()); 
            Console.WriteLine(); 

            if (opCode >= 1 && opCode <= 4) 
             { 
                
                switch (opCode) 
                 { 
                    case 1: 
                    StackNoParams();  
                    break; 
                    case 2: 
                    StackWithParams(0, 1, 2); 
                    break; 
                    case 3: 
                    StackWithHeap(0, 1, new int[3]{1,2,3}); 
                    break; 
                    case 4:     
                    StackOver(4); 
                    break; 
                    case 5: 
                    Console.WriteLine("Good bye!"); 
                    done = true; 
                    break; 
                    default: 
                    Console.WriteLine("Invalid choice. Try again."); 
                    break; 
                }        
            } 
        } 

           static void StackNoParams() { 
                char letter1 = 'H'; 
                Console.WriteLine(letter1);
                char letter2 = 'E'; 
                Console.WriteLine(letter2); 
                char letter3 = 'L'; 
                Console.WriteLine(letter3); 
                char letter4 = 'L'; 
                Console.WriteLine(letter4); 
                char letter5 = 'O'; 
                Console.WriteLine(letter5); 
            } 

            static void StackWithParams(int num1, int num2, int num3)  
            { 
                Console.WriteLine($"{num1}, {num2}, {num3}"); 
            } 

            static void StackWithHeap(int num1, int num2, int[] num3)  
            { 
                num1 = 1; 
                Console.WriteLine(num1); 

                num2 = 2; 
                Console.WriteLine(num2); 

                num3 = new int[3]; 
                Console.WriteLine(num3); 
            } 


            static void StackOver(int x)  
            { 
                StackOver(x); 
            } 

    } 

} 