using System;

namespace ProjectPartA_A1
{
    class Program
    {
        struct Article
        {
            public string Name;
            public decimal Price;

             public override string ToString() => $"Please enter name and price for the article [] in the format; price (Exempel banan; 200): {Name}; {Price}";
        
        }

        const int _maxNrArticles = 10;
        const int _maxArticleNameLength = 20;
        const decimal _vat = 0.25M;

        static Article[] articles = new Article[_maxNrArticles];
        static int nrArticles;

        static void Main(string[] args)
        {
            ReadArticles();
            PrintReciept();
        }

        private static void ReadArticles()
        {
            //Your code to enter the articles
        Console.WriteLine($"How many articles do you want (between 1 and {_maxNrArticles})");
        string _sinput = Console.ReadLine();
        int _dinput = int.Parse(_sinput);
        
        

        }
        private static void PrintReciept()
        {
            //Your code to print out a reciept

        }
    }
}
