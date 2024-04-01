// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        // This code will show menu
        Recipe recipe = new Recipe();
        while (true)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter 1 to Enter Recipe Details");
            Console.WriteLine("Enter 2 to Display Recipe");
            Console.WriteLine("Enter 3 to Scale Recipe");
            Console.WriteLine("Enter 4 to Reset Quantities");
            Console.WriteLine("Enter 5 to Clear Recipes");
            Console.WriteLine("Enter 6 to Exit");
            Console.WriteLine("------------------------------------------------");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    recipe.EnterData();
                    break;
                case "2":
                    recipe.RecipeDisplay();
                    break;
                case "3":
                    Console.WriteLine("Enter a scale of 0.5,2 or 3");
                    double scale1 = Convert.ToDouble(Console.ReadLine());
                    recipe.RecipeScale(scale1);
                    break;
                case "4":
                    recipe.ResetRecipe();
                    break;
                case "5":
                    recipe.ClearRecipe();
                    break;
                case "6":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Wrong value. Please try again");
                    break;
            }
        }
    }
}

class Recipe
{
    private String[] ingredients;
    private double[] amount;
    private String[] units;
    private String[] steps;

    public Recipe()
    {
        ingredients = new string[0];
        amount = new double[0];
        units = new String[0];
        steps = new String[0];
    }
    public void EnterData()
        // this code is for the data to be entered for example the quantity
    {
        Console.WriteLine("Enter Number of Ingredients:");
        int ingNum = Convert.ToInt32(Console.ReadLine());

        ingredients = new string[ingNum];
        amount = new double[ingNum];
        units = new String[ingNum];

        for(int i = 0; i < ingNum; i++)
        {
            Console.WriteLine($"Enter Ingredients Details#{i + 1}:");
            Console.Write("Name:");
            ingredients[i] = Console.ReadLine();
            Console.Write("Quantity:");
            amount[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Units of Measurement:");
            units[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter Number of Steps:");
        int stpNum = Convert.ToInt32(Console.ReadLine());
        steps = new string[stpNum];

        for(int a = 0; a < stpNum; a++)
        {
            Console.Write($"Steps#{a+1}:");
            steps[a] = Console.ReadLine();
        }
    }

    public void RecipeDisplay()
        // to display the the recipe
    {
        Console.WriteLine("Ingredients:");
        for(int i = 0; i < ingredients.Length; i++)
        
        {
        Console.WriteLine($" - {amount[i]}{units[i]} of {ingredients[i]}");
        }
        Console.WriteLine("Steps:");
        for(int a = 0; a < steps.Length; a++)
        {
            Console.WriteLine($" - {steps[a]}");
        }
    }
    public void RecipeScale(double scale)
        // this code is to double the amount
    {
        for(int i = 0;i < amount.Length; i++)
        {
            amount[i] *= scale;
        }
    }
    public void ResetRecipe()
        // this is to reset the new amount to the orginal amount
    {
        for( int i=0;i<amount.Length; i++)
        {
            amount[i] /= 2;
        }
    }
    public void ClearRecipe()
        // Code to clear the whole recipe
    {
        ingredients = new string[0];
        amount = new double[0];
        units = new String[0];
        steps = new String[0];
    }
}