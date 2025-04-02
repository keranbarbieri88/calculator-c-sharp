//Sum();
//Subtration();
//Division();
Multiplication();


static void Sum(){

    //Método para limpar | Method to clean
    Console.Clear();

    //Método que permite que o usuário escreva e pula uma linha | Method that allows the user to write and skip a line
    Console.WriteLine("Enter the first value: ");
    // O método console.readline sempre retorna uma string, há necessidade de parse.| The console.readline method always returns a string, there is a need for parse.
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second value: ");
    float number2 = float.Parse(Console.ReadLine());

    //Para pular linha | To skip line
    Console.WriteLine("");

    float resultado = number1 + number2;

    //Interpolação | Interpolation
    Console.WriteLine($"The result is: {resultado}");
    //Concatenação | Concatenation
    //Console.WriteLine("The result is: " + resultado);

    //Permitirá que o programa contie a executar
    Console.ReadKey();
}

static void Subtration(){
    
    Console.Clear();

    Console.WriteLine("Enter the first value: ");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second value: ");
    float number2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = number1 - number2;
    Console.WriteLine($"The result is: {resultado}");
}

static void Division(){
    Console.Clear();

    Console.WriteLine("Enter the first value: ");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second value: ");
    float number2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = number1 / number2;
    Console.WriteLine($"The result is: {resultado}");
    Console.ReadKey();
}    

static void Multiplication(){
    Console.Clear();

    Console.WriteLine("Enter the first value: ");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second value: ");
    float number2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = number1 * number2;
    Console.WriteLine($"The result is: {resultado}");
    Console.ReadKey();
}