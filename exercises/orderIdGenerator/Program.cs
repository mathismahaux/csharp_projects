// Faire cela au lieu d'écrire un commentair à chaque ligne de code.
/*
    Le code suivant génère 5 identifiants de commande aléatoires. 
    Chaque identifiant de commande est composé d'un préfixe et d'un suffixe. 
    Le préfixe est une lettre majuscule aléatoire comprise entre A et E. 
    Le suffixe est un nombre aléatoire compris entre 1 et 999, complété par des zéros à gauche pour obtenir une 
    longueur de 3 caractères. 
    Exemple: A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}