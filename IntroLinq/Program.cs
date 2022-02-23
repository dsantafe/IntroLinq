using IntroLinq;

#region Linq Parte 1
var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

//var sum = 0.0;
//foreach (var number in numbers)
//    sum += number;

//lambda
var sum = numbers.Sum();
var max = numbers.Max();
var min = numbers.Min();
var avg = numbers.Average();
var first = numbers.FirstOrDefault();
var last = numbers.LastOrDefault();
var count = numbers.Count();
var twoElems = numbers.Take(2);
var numbersDesc = numbers.OrderByDescending(x => x);

//querys
var pairs = from x in numbers
            where (x % 2) == 0
            select x;

//pairs = numbers.Where(x => (x % 2) == 0).Select(x => x);

var mayorQue5 = from x in numbers
                where x > 5
                select x;

//mayorQue5 = numbers.Where(x => x > 5).Select(x => x);

var entre5y7 = from x in numbers
               where x >= 5 && x <= 7
               select x; 
#endregion

var books = Book.Books();
var authors = Author.Books();

//Mostrar en consola los 3 libros con más ventas. *
//Mostrar en consola los 3 libros con menos ventas. *
//Mostrar en consola el autor con más libros publicados.
//Mostrar en consola el autor y la cantidad de libros publicados. *
//Mostrar en consola los libros publicados hace menos de 50 años. *
//Mostrar en consola el libro más viejo. *
//Mostrar en consola los autores que tengan un libro que comience con "El". *

var ex1 = books.OrderByDescending(x => x.Sales).Take(3).ToList();
var ex2 = books.OrderBy(x => x.Sales).Take(3).ToList();
var ex3 = books.Where(x => x.PublicationDate > DateTime.Now.AddYears(-50).Year).ToList();
var ex4 = books.OrderBy(x => x.PublicationDate).FirstOrDefault();
var ex5 = from b in books
          join a in authors on b.AuthorId equals a.AuthorId
          where b.Title.ToLower().StartsWith("el")
          select a;
var ex6 = from b in books
          join a in authors on b.AuthorId equals a.AuthorId
          group a by a.Name into query
          select query;

foreach (var item in ex6)
    Console.WriteLine("Autor: " + item.Key + "Cantidad: " + item.Count());

foreach (var item in ex1)
    Console.WriteLine($"{item.Title} {item.Sales}");

/*
    SELECT a.Name, Count(*)
    FROM Book b
    JOIN Author a ON b.AuthorId = a.AuthorId
    GROUP BY a.Name
    
    Glenn Cooper    3
    Dann Brown      2
 */


