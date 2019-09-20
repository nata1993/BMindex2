using System;

namespace BMIcalculator
{
    class Program
    {
        static void Main()
        {
            float height;       //height is represented in meters with decimal point
            byte weight;        //weight is usually way below 255 kg hence byte is used because of conserving memory
            string fullName;
            byte age;           //human does not live over 255 years hence byte is used because of conserving memory 
            double y;           //BMI according to "new" BMI calculating formula
            float z;            //BMI according to "old" BMI calculating formula
            double x;           //exponenting number for new BMI formula

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
                if (age < 20)                   //if age is smaller than 20, runs information about underage and does not run calculator
                {
                    Console.WriteLine($"Your age is {age}. I am sorry to inform you but you are underaged to partake in this BMI calculating test.");
                    Console.WriteLine("You must be at least 20 years old for calculator to calculate ACCURATELY your BMI.");
                    Console.WriteLine("This calculator calculates most accurately BMI if you are in the age of between 20 to 65");
                }

                else if (age > 65)              //if age is over 65, runs information about overage and does not run calculator
                {
                    Console.WriteLine($"Your age is {age}. I am sorry to inform you but you are overaged to partake in this BMI calculating test.");
                    Console.WriteLine("You must be not more than 65 years old for calculator to calculate ACCURATELY your BMI.");
                    Console.WriteLine("This calculator calculates most accurately BMI if you are in the age of between 20 to 65");
                }
            }

            if (age >= 20 && age <= 65)
            {
                Console.WriteLine("Thank you. Now, please insert your height in meters.");
                height = float.Parse(Console.ReadLine());   //Converting inserted height string in meters into decimal floating point number
                Console.WriteLine();
                Console.WriteLine("Thank you. Now, please insert your weight in kilograms.");
                weight = byte.Parse(Console.ReadLine());    //converting inserted weight string in kilograms into 8 bit number
                z = weight / (height * height);             //calculating double precicion point BMI which is assigned name Z
                Console.WriteLine();
                Console.Write("Your BMI is: " + string.Format("{0:0.00}", z));       //string.format converts the number to two decimal points
                Console.WriteLine();
                Console.WriteLine("However, this is according to old calculation method.");
                Console.WriteLine("According to new calculation method, your BMI is calculated with formula below.");
                Console.WriteLine("BMI = 1.3 * (weight / (height) by the power of 2.5)");
                x = Math.Pow(height, 2.5);                  //calculating exponented number of height
                y = 1.3 * weight / x;                       //calculating BMI according to new formula
                Console.WriteLine();
                Console.WriteLine("Your BMI according to new calculating formula is: " + string.Format("{0:0.00}", y));      //string.format converts the number to two decimal points
                Console.WriteLine("It may differ from old formula calculation but it also may not.");

                //conditions for advising based on calculated BMI
                if (y < 16)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is way below acceptable limits. You must see your doctor because your life is in danger!");
                }

                if (y >= 16 && y < 18.5)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is low, you are underweighted. You must see your doctor because you might have some healt issues.");
                }

                if (y >= 18.6 && y < 25)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is normal and you are not under nor overweighted.");
                }

                if (y >= 25.1 && y < 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is not good and you are little overweighted.");
                }

                if (y >= 30.1 && y < 35)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is bad. You are overweighted.");
                }

                if (y >= 35.1 && y < 40)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is high, you are severely overweighted.");
                }

                if (y > 40.1)
                {
                    Console.WriteLine();
                    Console.WriteLine("NB! Your BMI is too high. Your life is in danged because of overweight. Please consult with your doctor on this matter.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
