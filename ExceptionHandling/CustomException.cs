namespace ExceptionHandling;

public class CustomException
{
    internal void LevelOneException()
    {
        try
        {
            // Code that may throw an exception
            int a = 5;
            int b = 0;
            int result = a / b; // Division by zero exception will occur here
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw new Exception(); //rethrow the DividedByZeroException again
        }
        catch (Exception ex) // Catch all other exceptions
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }
    }
    internal void LevelTwoException()
    {
        try
        {
            try
            {
                // Code that may throw an exception
                int a = 5;
                int b = 0;
                int result = a / b; // Division by zero exception will occur here
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception(); //rethrow the DividedByZeroException again
            }
        }
        catch (Exception ex) // Catch all other exceptions
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }
    }
}