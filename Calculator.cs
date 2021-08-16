namespace Submodule
{
    public class Calculator 
    {
        double add (double a, double b) => a + b;

        double subtract (double a, double b) => a - b;

        double multiply (double a, double b) => a * b;

        double divide (double a, double b) {
            try
            {
                return a/b;
            }
            catch (System.Exception ex)
            {
                 throw ex;
            }
        }
    }
}