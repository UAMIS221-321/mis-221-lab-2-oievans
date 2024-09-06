// Start Main

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMT = 0.1;

int numOfSandwiches = NumSandwiches();
int numOfToppings = NumToppings();
double tip = GetTip();

double totalSandwichCost = SandwichCost(numOfSandwiches, COST_OF_SANDWICH);
double totalToppingCost = ToppingsCost(numOfToppings, COST_OF_TOPPING);
double baseCost = totalSandwichCost + totalToppingCost;

TotalOrderCost(tip, baseCost, DISCOUNT_AMT);


// End Main

static int NumSandwiches()
{
    System.Console.WriteLine("Please input how many sandwiches");
    return int.Parse(Console.ReadLine());
}

static int NumToppings()
{
    System.Console.WriteLine("Please input the number of toppings");
    return int.Parse(Console.ReadLine());
}

static double GetTip()
{
    System.Console.WriteLine("Please input the amount you would like to tip as a decimal");
    return double.Parse(Console.ReadLine());
}

static double SandwichCost(double numSand, double sandCost)
{
    return numSand * sandCost;
}

static double ToppingsCost(double numToppings, double toppingsCost)
{
    return numToppings * toppingsCost;
}

static void TotalOrderCost(double tip, double cost, double discount)
{
    double orderCost = tip + cost * (1 - discount);
    double roundedCost = Math.Round(orderCost, 2);
    System.Console.WriteLine("Your total order cost is $" + roundedCost);
}