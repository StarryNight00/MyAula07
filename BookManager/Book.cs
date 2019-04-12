using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    internal class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        private static int bookCount;

        public static int GetBookCount() => bookCount;
        
        //Costrutor
        static Book()
        {
            bookCount = 0;
        }


        //Em projeto chamar Book book = new Book (arg 1, arg 2)
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            bookCount++;
        }

        //método com Lambda (=>) - simplifica retornos
        //Retorna um STRING correspondente ao valor da instância title da Classe
        public string GetTitle() => title;

        public string GetAuthor() => author;

        public int GetPages() => pages;

        public int GetWordCount() => wordCount;


        //Este método é void porque está a especificar um valor da instância, não a retornar um valor
        public void SetTitle(string title)
        {
            //Verificar se o title dado em argumento não é nulo
            //e tem um comprimento maior que 0 caractéres 
            if (title != null && title.Length > 0)
                this.title = title;
        }

        public int GetTitleLength()
        {
            return title.Length;
        }
        //Em Lambda:
        //public int GetTitleLength() => title.Length
    }
}
