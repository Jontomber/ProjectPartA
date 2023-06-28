using System;

namespace ProjectPartA_A1
{
    class Program
    {
        struct Article
        {
            public string Name;
            public decimal Price;
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
        }
        private static void PrintReciept()
        {
            //Your code to print out a reciept

        }
    }
}
