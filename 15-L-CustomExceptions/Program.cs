namespace CustomException
{
    // Custom exception
    public class InvalidProductException : Exception
    {
        public InvalidProductException(string message) : base(message) 
        {
        } 
        
            
        
    }


    // Product class
    public class Product
    {
        private string name;
        private double price;
        public Product(string name, double price)
        {
           try {
                if (string.IsNullOrEmpty(name) || name.Length <= 2)
                {
                    throw new InvalidProductException("[ERROR]: Check if product name is set and name needs to have atleast 3 characters.");
                }
                if (price <= 0)
                {
                    throw new InvalidProductException("[ERROR]: Product price cannot be equal or lower than 0.");
                }
                this.name = name;
                this.price = price;
           } 
           catch(InvalidProductException e)
           {
                Console.WriteLine(e.Message);
           }
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: {price}");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {

            // OK, no errors.
            Product car = new Product("Porche", 65855);
            car.ShowProductDetails();

            // WRONG, exceptions has been thrown.
            Product wrongProduct = new Product("abc", 0);
            wrongProduct.ShowProductDetails();

            // WRONG, exceptions has been thrown.
            Product wrongProduct2 = new Product("", 1);
            wrongProduct2.ShowProductDetails();
        }
    }
}
