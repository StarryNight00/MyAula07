using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int nLivros;
            string aux;

            Book[] livros;

            //Pedir total de livros
            Console.Write("Quantos livros pretende registar? ");
            aux = Console.ReadLine();
            nLivros = Convert.ToInt32(aux);        //Compactado: totalLivros = Convert.ToInt32(Console.ReadLine());

            //Array
            livros = new Book[nLivros];
            
            //Um cliclo que para cada livro
            for (int i = 0; i < nLivros; i++)
            {
                //Variáveis
                string inputT, inputA;

                //Inputs
                Console.WriteLine("Qual o nome da obra?");
                inputT = Console.ReadLine();

                Console.WriteLine("Qual o autor?");
                inputA = Console.ReadLine();

                //Criar um novo Book
                //Guardar no array livros
                livros[i] = new Book(inputT, inputA);

                //Just for organization
                Console.WriteLine();
            }

            //Para cada livro imprimir titulo, Length e autor
            for (int i = 0; i < nLivros; i++)
            {

                //Imprimir título e comprimento
                Console.WriteLine();
                Console.WriteLine($"Livro {i + 1}");
                Console.WriteLine($"Título: {livros[i].GetTitle()} ({livros[i].GetTitleLength()})");

                //Imprimir autor
                Console.WriteLine($"Autor: {livros[i].GetAuthor()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Número total de livros inseridos: {Book.GetBookCount()}");
            Console.ReadLine();

        }
    }
}
