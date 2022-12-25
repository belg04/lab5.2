char[] input = Console.ReadLine().ToCharArray();
char t = input[0];
input[0] = input[input.Length - 1];
input[input.Length - 1] = t;
Console.WriteLine(new string(input));
Console.ReadKey();