string text = "", reverstext ="";

Console.WriteLine("escriba el texto que desera invertir");

text = Console.ReadLine();
// 1° metodo
for (int i = text.Length - 1 ; i>= 0 ; i--)
{
    reverstext += text[i];
}
// 2° metodo
char[] chars = text.ToCharArray();
Array.Reverse(chars);
reverstext = new string(chars);
//
Console.WriteLine(reverstext);
