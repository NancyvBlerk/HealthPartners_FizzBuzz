using HealthPartners_FizzBuzz;
using System.Text;
using static HealthPartners_FizzBuzz.Functionality;

//I haven't done this in a few years so I've done some research and found a lot of cool solutions


//I'll still be doing my own attmept but like to experiment so I've included some of those
//solutions to see how they work. Feel free to use their options if you're curious
Functionality func = new();
StringBuilder funcBob = new StringBuilder();
StringBuilder sb = new();
sb.AppendLine("Please select:");
sb.AppendLine("1. My own attempt");
sb.AppendLine("2. StackOverflow example");

Console.WriteLine(sb);
string read = Console.ReadLine() ?? "noInputError";

try
{
    if (read != null)
    {
        switch (read)
        {
            case "1":
                funcBob = func.MyOwn();
                break;
            case "2":
                //just wanted to see how this works, I've never used a Tuple
                //Very interesting!
                var combinations = new Tuple<int, string>[]
               {
                    new Tuple<int, string> (3, "Fizz"),
                    new Tuple<int, string> (5, "Buzz"),
               };

                for (int i = 1; i <= 100; ++i)
                {
                    bool found = false;

                    foreach (var comb in combinations)
                    {
                        if (i % comb.Item1 == 0)
                        {
                            found = true;
                            Console.Write(comb.Item2);
                        }
                    }

                    if (!found)
                    {
                        Console.Write(i);
                    }

                    Console.Write(Environment.NewLine);
                }
                break;
            default:
                funcBob.AppendLine("Please select between 1 - 2");
                break;
        }

        Console.WriteLine();
        Console.WriteLine(funcBob);
    }
    else
    {
        Console.WriteLine("ReadLine was not properly returned to the code");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
}
