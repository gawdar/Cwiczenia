
var solutions1 = "First solution";
var solutions2 = "Second solution";


Console.WriteLine(solutions1);

char[] alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".ToCharArray();

for (char i = 'a'; i <= 'z'; i++)
{
    Console.Write(i);
}
Console.WriteLine("");
Console.WriteLine("--------------------------");

foreach (char i in alphabet)
{
    Console.Write(i);
}
Console.WriteLine("");
Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

Console.WriteLine(solutions2);

List<string> lettersOfAlphabet = new List<string>();

lettersOfAlphabet.Add("A");
lettersOfAlphabet.Add("B");
lettersOfAlphabet.Add("C");
lettersOfAlphabet.Add("D");
lettersOfAlphabet.Add("E");
lettersOfAlphabet.Add("F");
lettersOfAlphabet.Add("G");
lettersOfAlphabet.Add("H");
lettersOfAlphabet.Add("I");
lettersOfAlphabet.Add("J");
lettersOfAlphabet.Add("K");
lettersOfAlphabet.Add("L");
lettersOfAlphabet.Add("M");
lettersOfAlphabet.Add("N");
lettersOfAlphabet.Add("O");
lettersOfAlphabet.Add("P");
lettersOfAlphabet.Add("Q");
lettersOfAlphabet.Add("R");
lettersOfAlphabet.Add("S");
lettersOfAlphabet.Add("T");
lettersOfAlphabet.Add("U");
lettersOfAlphabet.Add("V");
lettersOfAlphabet.Add("W");
lettersOfAlphabet.Add("X");
lettersOfAlphabet.Add("Y");
lettersOfAlphabet.Add("Z");


for (var i = 0; i < lettersOfAlphabet.Count; i++)
{
    Console.Write(lettersOfAlphabet[i]);
}
Console.WriteLine("");

foreach (var letter in lettersOfAlphabet)
{
    Console.Write(letter);
}
Console.WriteLine("");
Console.ReadKey();

