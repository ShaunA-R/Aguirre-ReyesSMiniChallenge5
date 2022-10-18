//Shaun Aguirre-Reyes
// 10/18/22
// this is the madlib  project. The computer asks for a response from the user for certain words and creates a story with it.

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){
Console.WriteLine("Lets write a story about the zoo");

Console.WriteLine("Choose an adjective");
string adjective = Console.ReadLine();

Console.WriteLine("Pick an animal");
string animal = Console.ReadLine();

Console.WriteLine("Now pick a dangerous action the animal might do");
string action = Console.ReadLine();

Console.WriteLine("Now give me a verb you would do after the animals action");
string verb = Console.ReadLine();

Console.WriteLine("Now give me a food item");
string food = Console.ReadLine();

Console.WriteLine("Now give me the color of ur shirt");
string color = Console.ReadLine();

Console.WriteLine("Now give me a verb that ends in ing");
string verb2 = Console.ReadLine();

Console.WriteLine("Give me an object");
string item = Console.ReadLine();

Console.WriteLine("Give me a number");
string number = Console.ReadLine();

Console.WriteLine("Give me a positive feeling");
string feeling = Console.ReadLine();








Console.WriteLine("It was a " + adjective + " day and you notice a " + animal + " which happens to be your favorite animal there. However you notice the animal starts to " + action + " and the cage is open!");

Console.WriteLine("Thinking quickly you decide to " + verb + " but unexpectedly ran into a person holding " + food + " spilling all over your " + color + " shirt");

Console.WriteLine("Without thinking about it you start " + verb2 + ".");

Console.WriteLine("Heading the other direction you didnt notice the " + item + " so you ran into it and fell" + " but when you look up you notice " + number + " workers running towards the " + animal + ".");

Console.WriteLine("Breathing a sigh of relief you feel " + feeling + " as you realize the crazy day is over.");

Console.WriteLine("Do you want to play again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}
