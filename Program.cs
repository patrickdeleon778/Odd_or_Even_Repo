

int num; // create a variable named num

bool isNum;
bool playAgain = true; // created a play again boolean setting it to true
bool validResponse = true;
string userAnswer; // created a variable named userAnswer which will be used to grab the user's input
string? userNum;



while(playAgain == true) // the code will run multiple times with this while loop unless you break out of it
{
    Console.Write("Enter a number: "); // console asks user to input a number

    do
    {
        userNum = Console.ReadLine();
        isNum = int.TryParse(userNum, out num);

        if(isNum != true)
        {
            Console.WriteLine("Please just enter a NUMBER... not " + userNum);
        }
    }
    while(isNum != true);
    //num = Convert.ToInt32(Console.ReadLine()); // user's input is stored in the variable "num"
 
    if (num % 2 == 0) // using the Modulo operator, if the user's number has a remainder of "0"
    {
        Console.WriteLine(num + " is an Even number!"); // console will print the user's number will be even
    }
    else // any other number that doesn't have a remainder of '0' will be odd
    {
        Console.WriteLine(num + " is an Odd number!"); // console prints the user's number if it's odd
    }

    validResponse = true; // changed validResponse back to true just in case the user wanted to run the program again after using it for the first time. If this line of code wasn't here it would cause the main while loop to constantly loop IF the user keeps inputting a number.

    while(validResponse == true) // a while loop that is set to true and it loops the 3 options below. "Y" to start the program over again, "N" to end the program and the e
    {
        Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

        userAnswer = Console.ReadLine().ToUpper();

        if (userAnswer == "Y") // if the user inputs "Y"
        {
            playAgain = true; // the code will run from the beginning
            validResponse = false; // the 2nd while loop will be set to false 
        }
        else if (userAnswer == "N") // if the user inputs "N"
        {
            playAgain = false; // the 1st while loop will end
            validResponse = false; // the 2nd while loop will end causing the whole code to END HERE
        }
        else // if the user inputs anything other than "Y" or "N"
        {
            validResponse = true; // this line of code repeats the 2nd while loop until they enter a valid response 
            playAgain = false; // playAgain gets set to false so user can't loop back to the beginning of the 1st while loop
            Console.WriteLine(userAnswer + " is not a valid response. Please enter a valid response."); // console displays a "error" message for the user
        }
    }
}
        Console.WriteLine("Thank you for playing!"); // after picking "N", both the while loops will end and display "Thank you for playing!"