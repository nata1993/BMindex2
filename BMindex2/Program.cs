using System;

namespace BMIcalculator2
{
    class Program
    {
        static void Main()
        {
            double height, BMInew;      //height is represented in meters with decimal point, BMInew according to "new" BMI calculating formula
            int weight;                 //weight is usually way below 255 kg hence byte is used because of conserving memory
            string fullName;
            byte age;                   //human does not live over 255 years hence byte is used because of conserving memory 

            //introduction
            Console.WriteLine("Hello! This is Body Mass Index (BMI) calculator. Insert your height and your weight");
            Console.WriteLine("and program will calculate your BMI.");
            Console.WriteLine("How does it calculate?");
            Console.WriteLine("The formula looks like this: BMI = weight / (height * height)");
            Console.WriteLine();
            Console.WriteLine("Lets start with introduction, shall we?");
            Console.WriteLine("My name is BMI CALCULATOR. What is your full name?");        //asking user name
            fullName = Console.ReadLine();
            Console.Write($"Nice to meet you {fullName}. ");
            Console.WriteLine("May i ask you how old are you?");                            //asking user age
            age = byte.Parse(Console.ReadLine());

            if (age < 20 || age > 65)
            {
                if(age < 20)                   //if age is smaller than 20, runs information about underage and does not run calculator
                {
                    Console.WriteLine($"Your age is {age}. I am sorry to inform you but you are underaged to partake in this BMI calculating test.");
                    Console.WriteLine("You must be at least 20 years old for calculator to calculate ACCURATELY your BMI.");
                    Console.WriteLine("This calculator calculates most accurately BMI if you are in the age of between 20 to 65");
                }

                else if(age > 65)              //if age is over 65, runs information about overage and does not run calculator
                {
                    Console.WriteLine($"Your age is {age}. I am sorry to inform you but you are overaged to partake in this BMI calculating test.");
                    Console.WriteLine("You must be not more than 65 years old for calculator to calculate ACCURATELY your BMI.");
                    Console.WriteLine("This calculator calculates most accurately BMI if you are in the age of between 20 to 65");
                }
            }

            else
            {
                Console.WriteLine("Thank you. Now, please insert your height in meters.");
                height = float.Parse(Console.ReadLine());       //Converting inserted height string in meters into decimal floating point number
                Console.WriteLine();
                Console.WriteLine("Thank you. Now, please insert your weight in kilograms.");
                weight = int.Parse(Console.ReadLine());         //converting inserted weight string in kilograms into 16 bit number
                Console.WriteLine();
                Console.WriteLine($"Your BMI is: {Math.Round(weight / (height * height), 2)}");         //Calculates and rounds float point number to two decimal point number             
                Console.WriteLine();
                Console.WriteLine("However, this is according to old calculation method.");
                Console.WriteLine("By new calculation method, your BMI is calculated with formula below.");
                Console.WriteLine("BMI = 1.3 * (weight / (height) by the power of 2.5)");
                BMInew = Math.Round(1.3 * weight / (Math.Pow(height, 2.5)), 2);                         //calculating BMI according to new formula
                Console.WriteLine();
                Console.WriteLine($"Your BMI according to new calculating formula is: {BMInew}");       //Math.Round rounds float number to two decimal points
                Console.WriteLine("It may differ from old formula calculation but it also may not.");

                //conditions for advising based on calculated BMI
                if (BMInew < 16)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is way below acceptable limits. You must see your doctor because your life is in danger!");
                }

                else if (BMInew >= 16 && BMInew < 18.5)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is low, you are underweighted. You must see your doctor because you might have some healt issues.");
                }

                else if (BMInew >= 18.6 && BMInew < 25)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is normal and you are not under nor overweighted.");
                }

                else if (BMInew >= 25.1 && BMInew < 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is not good and you are little overweighted.");
                }

                else if (BMInew >= 30.1 && BMInew < 35)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is bad. You are overweighted.");
                }

                else if (BMInew >= 35.1 && BMInew < 40)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is high, you are severely overweighted.");
                }

                else
                {
                        Console.WriteLine();
                        Console.WriteLine("NB! Your BMI is too high. Your life is in danged because of overweight. Please consult with your doctor on this matter.");
                }
            }
            Console.ReadLine();
        }
    }
}