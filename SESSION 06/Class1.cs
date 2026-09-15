

namespace SESSION_06;

internal class Questions

{



    public static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }

    public static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }
    //public static void AddBonusPages(int pages)
    //{
    //    pages = pages + 50;
    //    Console.WriteLine(pages);


    //}

    public static void ApplyDiscount(double[] prices)
    {
        prices[0] = prices[0] - 5;
    }

//   public static void ReplaceArray(ref double[] prices)
//    {
//        prices = new double[] { 10.0, 12.5, 15.0 };
//    }

// public static bool TryGetPrice(string title, out double price)
// { 
//        if (title == "Clean Code")
//        {
//            price = 25.5;
//            return true;
//        }

//        price = 0;
//        return false;
//    }
//}
