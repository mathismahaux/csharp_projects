// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("Sum Sophia: " + sophiaSum);
Console.WriteLine("Sum Nicolas: " + nicolasSum);
Console.WriteLine("Sum Zahirah: " + zahirahSum);
Console.WriteLine("Sum Jeong: " + jeongSum);
Console.WriteLine();

// Pour que le résultat d'une division soit un décimal, numérateur et dénominateur doivent être décimaux,
// Ou, si numérateur et dénominateurs sont entiers => Convertir les valeurs en décimal
decimal sophiaAverage = (decimal) sophiaSum / currentAssignments;
decimal nicolasAverage = (decimal) nicolasSum / currentAssignments;
decimal zahirahAverage = (decimal) zahirahSum / currentAssignments;
decimal jeongAverage = (decimal) jeongSum / currentAssignments;

// \t => Formate l'output en tant que colonnes de texte alignées
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaAverage + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasAverage + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahAverage + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongAverage + "\tA");