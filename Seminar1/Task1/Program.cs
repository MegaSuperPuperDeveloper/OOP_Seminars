public class Program {
    static void Main() {
        Product product1 = new Product(1, "Chip Lays", 132.90, 13);
        Product product2 = new Product(2, "Chocolate", 10.90, 3);
        Product product3 = new Product(3, "Candy", 1300, 134);

        Bottle bottle1 = new Bottle(4, "Protein", 12312, 123, 10);

        List<Product> ourList = new List<Product>();
        ourList.Add(product1);
        ourList.Add(product2);
        ourList.Add(product3);
        ourList.Add(bottle1);

        Holder holder = new Holder();
        Display display = new Display();
        CoinDespenser coinDespenser = new CoinDespenser();

        VendingMachine machine = new VendingMachine(holder, display, coinDespenser, ourList);

        foreach (Product item in ourList) {
            System.Console.WriteLine(item.toString());
        }
        
    }
}