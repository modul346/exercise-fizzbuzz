# exercise-fizzbuzz

## Create the Azure function fizzbuzz that works as follows:

A number is passed to the function in the query string with a parameter that is called "number"

1. If the number is divisible by 3 the function returns the value "Fizz"
2. If the number is divisible by 5 the function returns the value "Buzz"
3. If the number is divisible by 3 and 5 the function returns the value "FizzBuzz"
4. if the number is neither divisible by 3 nor 5 the function returns the number as string.

## Additional Challenge 

1. If the function is called with no value for nummber or with a non-numeric value for number then return a BadRequestObjectResult