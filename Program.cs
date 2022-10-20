//Harrison Busby
//10/18/2022
//Mini Challenge 8
//Guess it

string easy;
string medium;
string hard;
string custom;
string gameMode;
string playAgain = "yes";
string userInput = "";
int guess;
int number;
int guesses;
bool isNumber = false;
bool isConverted = true;
int validNumber = 0;
Random random = new Random();

Console.Clear();

while(playAgain == "yes"){

Console.WriteLine("Hi there, this is the Guessing Game. Would you like to play on easy, medium, hard, or custom?");
gameMode = Console.ReadLine().ToLower();


if(gameMode != "easy" && gameMode != "medium" && gameMode != "hard" && gameMode != "custom"){
Console.WriteLine("Please give a valid Game Mode.");

}

switch(gameMode){
    case "easy":

    guess = 0;
    guesses = 0;
number = random.Next(1,10);
while(validNumber != number){
    Console.WriteLine("You have chosen " + gameMode + " mode.");
    Console.WriteLine("Guess a number between 1 and 10");

while(isNumber == false){
       
      
userInput = Console.ReadLine();
isNumber = Int32.TryParse(userInput, out validNumber);

if(isNumber == false){
Console.WriteLine("Please enter a valid response.");
}else{
    Console.WriteLine("Guess: " + userInput);

    if(guess > number){
        Console.WriteLine(guess + " is too high.");
    }else if(guess < number){
        Console.WriteLine(guess + " is too low.");
    }
guesses++;
}

Console.WriteLine("Number: " + number);
Console.WriteLine("Great job!");
Console.WriteLine("It took you: " + guesses + " guesses.");
}
}

break;
   
    case "medium":
    
    guess = 0;
    guesses = 0;
number = random.Next(1,50);
while(guess != number){
    Console.WriteLine("You have chosen " + gameMode + " mode.");
    Console.WriteLine("Guess a number between 1 and 50");
    guess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Guess: " + guess);

if(guess > number){
    Console.WriteLine(guess + " is too high.");
}else if(guess < number){
    Console.WriteLine(guess + " is too low.");
}
guesses++;
}

Console.WriteLine("Number: " + number);
Console.WriteLine("Great job!");
Console.WriteLine("It took you: " + guesses + " guesses.");

break;
    
    case "hard":
    
    guess = 0;
    guesses = 0;
number = random.Next(1,100);
while(guess != number){
    Console.WriteLine("You have chosen " + gameMode + " mode.");
    Console.WriteLine("Guess a number between 1 and 100");
    guess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Guess: " + guess);

if(guess > number){
    Console.WriteLine(guess + " is too high.");
}else if(guess < number){
    Console.WriteLine(guess + " is too low.");
    }
guesses++;
}

Console.WriteLine("Number: " + number);
Console.WriteLine("Great job!");
Console.WriteLine("It took you: " + guesses + " guesses.");
break;
    
    
    case "custom":
    
    guess = 0;
    guesses = 0;
    Console.WriteLine("You have chosen " + gameMode + " mode.");
    Console.WriteLine("Please input a minumum value.");
    int choiceOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input a maximum value.");
    int choiceTwo = Convert.ToInt32(Console.ReadLine());

    guess = 0;
    guesses = 0;
number = random.Next(choiceOne, choiceTwo);
while(guess != number){
    Console.WriteLine("You have chosen " + gameMode + " mode.");
    Console.WriteLine("Guess a number between " + choiceOne + " and " + choiceTwo + ".");
    guess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Guess: " + guess);

if(guess > number){
        Console.WriteLine(guess + " is too high.");
    }else if(guess < number){
        Console.WriteLine(guess + " is too low.");
    }
guesses++;
}

Console.WriteLine("Number: " + number);
Console.WriteLine("Great job!");
Console.WriteLine("It took you: " + guesses + " guesses.");

break;
}

 Console.WriteLine("Would you like to play again? Type 'yes' to play again, type anything else to quit.");
playAgain = Console.ReadLine().ToLower();

if(playAgain == "yes"){
    Console.WriteLine("Lets play again!");
}else{
    Console.WriteLine("Go away");
}
}

    
    