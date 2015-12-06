using System;

class Program
{

    static string Caesar(string value, int shift)
    {
	char[] buffer = value.ToCharArray();
	for (int i = 0; i < buffer.Length; i++)
	{
	    // Letter.
	    char letter = buffer[i];
	    // Add shift to all.
	    letter = (char)(letter + shift);
	    // Subtract 26 on overflow.
	    // Add 26 on underflow.
	    if (letter > 'z')
	    {
		letter = (char)(letter - 26);
	    }
	    else if (letter < 'a')
	    {
		letter = (char)(letter + 26);
	    }
	    // Store.
	    buffer[i] = letter;
	}
	return new string(buffer);
    }

    static void Main()
    {
	string a = "KYMJR FYMJR FYNHF QLJSN";
	string b = Caesar(a, 1); // Ok


	Console.WriteLine(a);
	Console.WriteLine(b);

    }
}
