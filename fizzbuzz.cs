using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class fizzbuzz
    {

        // Create the function fizzbuzz that works as follows:
        //
        // a number is passed to the function in the query string with a parameter that is called number
        //
        // if the number is divisible by 3 the function returns the value "Fizz"
        // if the number is divisible by 5 the function returns the value "Buzz"
        // if the number is divisible by 3 and 5 the function returns the value "FizzBuzz"
        // if the number is neither divisible by 3 nor 5 the function returns the number as string.

        [FunctionName("fizzbuzz")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            // First we get the parameter from the querystring
            string numberAsString = req.Query["number"];

            log.LogInformation("FizzBuzz Function started with the value " + numberAsString);

            // Next we convert the string value into an integer value (if possible)
                        
            int number = -1;
            if (int.TryParse(numberAsString, out int value))
            {
                number = value;
            }
           
            string responseMessage = "";

             // here your work starts: Fill the response message according to the specification.

             responseMessage = "FizzBuzz is missing the implementation!";

             // tip: the modulo calculation could be useful in the solution of this problem
             // int a = 10 % 7; the value of a is 3
             // int b = 14 % 7; the value of b is 0



            return new OkObjectResult(responseMessage);
        }
    }
}
