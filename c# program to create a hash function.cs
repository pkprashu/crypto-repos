// C# Program to create a Hash
// Function for String data
using System;

class Geeks {
	
	// Main Method
	public static void Main(String []args)
	{
		
		// Declaring the an string array
		string[] values = new string[50];
		string str;

		// Values of the keys stored
		string[] keys = new string[] {"C", "C++",
				"Java", "Python", "C#", "HTML"};

		int hashCode;

		for (int k = 0; k < 5; k++) {
			
			str = keys[k];
			hashCode = HashFunction2(str, values);

			// Storing keys at their hashcode's index
			values[hashCode] = str;
		}

		// Displaying Hashcodes along with key values
		for (int k = 0; k < (values.GetUpperBound(0)); k++) {
			
			if (values[k] != null)
				Console.WriteLine(k + " " + values[k]);
		}
	}

	// Defining the hash function
	static int HashFunction2(string s, string[] array)
	{
		long total = 0;
		char[] c;
		c = s.ToCharArray();

		// Horner's rule for generating a polynomial
		// of 11 using ASCII values of the characters
		for (int k = 0; k <= c.GetUpperBound(0); k++)
		
			total += 11 * total + (int)c[k];

		total = total % array.GetUpperBound(0);
		
		if (total < 0)
			total += array.GetUpperBound(0);

		return (int)total;
	}
}
