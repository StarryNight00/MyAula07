using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //método com Lambda (=>) - simplifica retornos
        //Retorna um STRING correspondente ao valor da instância title da Classe
        public string GetTitle() => title;


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
