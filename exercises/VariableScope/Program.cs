string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

Console.WriteLine("-------------------------------------------------------");

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);


// double circumference = 2 * pi * radius;
// =>
// M:\CSharp\chap5\variablescope\Program.cs(18,28): error CS0103: The name 'pi' does not exist in the current context
// M:\CSharp\chap5\variablescope\Program.cs(18,33): error CS0103: The name 'radius' does not exist in the current context

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}