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
sb.AppendLine("3. Example in document");

Console.WriteLine(sb);
string read = Console.ReadLine() ?? "noInputError";

try
{
    if (read != null && string.IsNullOrEmpty(read))
    {
        switch (read)
        {
            case "1":
                funcBob = func.MyOwn();
                break;
            case "2":
                funcBob = func.StackOverflow();
                break;
            case "3":
                funcBob = func.DocExample();
                break;
            default:
                funcBob.AppendLine("Please select between 1 - 3");
                break;
        }

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
