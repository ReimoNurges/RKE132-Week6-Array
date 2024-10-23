string hello = "  hello, world!  ";

int stringLength = hello.Length;
string trimmedstring = hello.Trim();

hello = hello.Trim();

int wordcounter = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordcounter++;
    }
}

Console.WriteLine(("word count in " ) + (hello) + (": ") + (wordcounter));
