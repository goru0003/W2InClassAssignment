namespace W2InClassAssignment;

public class Program
{
    
    static void Main(string[] args)
    {
        Book book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        book.DisplayInfo();
        
        Student student = new Student();
        student.Name = "Jack";
        student.Grade = 75;

        Console.WriteLine($"{student.Name} is passing: {student.IsPassing()}");
        
        Engine engine = new Engine(450);
        Car car = new Car("Mustang", engine);
        car.Describe();
        
        Console.WriteLine("Counter:"+Vowels.CountVowels("Hello World"));          // 3
      

    }
}


