// Kirjoita ohjelma, joka kysyy käyttäjältä montako lukua arvotaan. 
// Kysymisen jälkeen ohjelma tulostaa kyseisen määrän satunnaisia
// kokonaislukuja 1 ja 50 väliltä.
Console.Write("Montako lukua arvotaan: ");
int maara = int.Parse(Console.ReadLine());

Random rnd = new Random();
for (int i = 0; i < maara; i++)
{
    Console.WriteLine(rnd.Next(1, 50));
}