// string word = "word"; 
// int a = 10; 
// Console.WriteLine(word+a);
// string userInput = "A"; 
// int number =  7; 
// string @class = "class"; 



Console.WriteLine("Hello");
Console.Write("Input Option: "); 
string userChoice = Console.ReadLine(); 
Console.WriteLine("UserInput: " + userChoice); 

void PrintSelectedOption(string selectedOption){
    Console.WriteLine("Selected Option: " + selectedOption);
}

int Add(int a, int b){
    return a+b; 
}


Console.WriteLine("sum = " + Add(5,5)); 
if(userChoice == "S") PrintSelectedOption("[S]ee all TODOs");
else if(userChoice == "A") PrintSelectedOption("[A]dd a TODO"); 
else if(userChoice == "R") PrintSelectedOption("[R]emove a TODO");
else if(userChoice == "E") PrintSelectedOption("[E]xit"); 





