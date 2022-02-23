using IntroLinq;

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

var books = Book.Books();
var authors = Author.Books();

foreach (var item in books)
    Console.WriteLine(item.Title);

var query1 = from x in books
             where x.PublicationDate > 1900
             select x;

query1 = books.Where(x => x.PublicationDate > 1900).Select(x => x);





