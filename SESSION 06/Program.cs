namespace SESSION_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region QUESTIONS 1
            ///indext 0=25.5 or indext1=40.0 or indext2=33.75
            double[] prices = [25.5, 40.0, 33.75];
            {
                Console.WriteLine(prices[1]);
            }
            #endregion
            #region Questions 02
            ///array of multidimesnsional
            int[,] shelfCopies = {{ 3, 5 },
    { 1, 4 }};

            Console.WriteLine(shelfCopies[1, 0]);

            #endregion
            #region Questions 03

            Questions.PrintWelcomeMessage();


            #endregion
            #region Qestions 04
            Questions.PrintBookTitle("clean code");

            #endregion
            #region Questions 05
            //give me an error
            //int pages = 400;
            //Questions.AddBonusPage(pages);

            #endregion
            #region Questions 06
          
            { 
            static void Main()
            {
                double[] prices = { 25.5, 40.0 };

               Questions. ApplyDiscount(prices);

                Console.WriteLine(prices[0]);
            }
        }
            #endregion
            #region Questions 07
            //في class هنحط جنب public static void AddBonusPages( refint pages)برضه 
            //int pages = 400;
            //Questions.AddBonusPage(ref pages);

            #endregion
            #region Qestions 08
            // double[] prices = { 25.5, 40.0, 33.75 };

            //Questions.ReplaceArray(ref prices);

            // Console.WriteLine(prices.Length);

            #endregion
            #region Questions 09
            //double price;

            //bool found = TryGetPrice("Clean Code", out price);

            //Console.WriteLine(found);
            //Console.WriteLine(price);
            #endregion
            #region Questions 10

            #endregion
            //// انا فاهم الشرح وكل حاجه بس كا اكتب كود بحناج سعات ان ابص اشوف كا بس لما السوال بيبقاا واضح بعمل الكود من غير ارجع بدايه ابدا
            //ازاي او يمكن كا تعريف سوال بحتاج توضيح لي السوال اكتر عشان اعرف ابدا في بصراحه سعات بستعين بي النت وبتبقا الحاجه الا في دماغي بس بحتاج توضيح السوال اكتر








        }
    }
}
