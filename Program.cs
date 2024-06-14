/**
//DAY 1.1

string firstName = ("Fernando Jose");
string middleName = ("Maniaga");
string lastName  = ("Magnaye");
int myAge = 22;
string myGender = "MALE";

Console.WriteLine("my Full name is " + " " +firstName +" "+ middleName +" "+ lastName );
Console.WriteLine("my age is " + myAge + " i am a " + myGender);
**/

/**
//DAY 1.2
Random random = new Random();
// int diceOne = random.Next(7);
// int diceTwo = random.Next(7);
// int diceThree = random.Next(7);

int diceOne = 5;
int diceTwo = 5;
int diceThree = 5;


int bonus = 0;

if(diceOne == diceTwo && diceTwo == diceThree){
    bonus = 6;
}

int  Score = diceOne + diceTwo + diceThree + bonus;
Console.WriteLine("Dice Roll: " + diceOne + " + " + diceTwo + " + " + diceThree  +  " + (BONUS " + bonus + ") = " + Score);
if(Score >= 15){
    Console.WriteLine(" CONGRATS!! YOU WON");
} else{
    Console.WriteLine(" SORRY.. YOU LOST ");
}
**/
/**
// DAY 3

//interpolation $(" write {nameOfVariable}")
int num1 = 95;
int num2 = 80;
int num3 = 90;

Console.WriteLine($"numbers [{num1}, {num2}, {num3}]. ");

int highest = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
int lowest = (num1 < num2) ? (num1 < num3 ? num1 : num3) : (num2 < num3 ? num2 : num3);

Console.WriteLine("HIGHEST: " + highest);
Console.WriteLine("LOWEST: " + lowest);
**/

int numberToCheck = 7;
 
if(numberToCheck %2 == 0){
    Console.WriteLine($"Number {numberToCheck} is even");
} else{
    Console.WriteLine($"Number {numberToCheck} is not even");
}






