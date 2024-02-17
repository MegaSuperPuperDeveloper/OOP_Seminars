public class Program {
    static void Main() {
        Product product1 = new Product(1, "Chip Lays", 132.90, 13);
        Product product2 = new Product(2, "Chocolate", 10.90, 3);
        Product product3 = new Product(3, "Candy", 1300, 134);

        Bottle bottle1 = new Bottle(4, "Protein", 12312, 123, 10);
        HotDrink coffee = new HotDrink(5, "Coffee", 100, 1, 80);
        HotDrink tea = new HotDrink(6, "Tea", 70.0, 1, 90);
        HotDrink hotChocolate = new HotDrink(7, "Hot Chocolate", 120.0, 1, 75);

        List<Product> ourList = new List<Product>();
        List<Bottle> ourList1 = new List<Bottle>();
        List<HotDrink> ourList2 = new List<HotDrink>();
        List<Product> ourList3 = new List<Product>();
        ourList.Add(product1);
        ourList.Add(product2);
        ourList.Add(product3);
        ourList.Add(bottle1);
        ourList.Add(coffee);
        ourList.Add(tea);
        ourList.Add(hotChocolate);

        ourList3.Add(product1);
        ourList3.Add(product2);
        ourList3.Add(product3);
        ourList1.Add(bottle1);
        ourList2.Add(coffee);
        ourList2.Add(tea);
        ourList2.Add(hotChocolate);

        Holder holder = new Holder();
        Display display = new Display();
        CoinDespenser coinDespenser = new CoinDespenser();

        VendingMachine machine = new VendingMachine(holder, display, coinDespenser, ourList);

        foreach (Product item in ourList3) {
            System.Console.WriteLine(item.toString());
        }

        foreach (Bottle item in ourList1) {
            System.Console.WriteLine(item.toString());
        }

        foreach (HotDrink item in ourList2) {
            System.Console.WriteLine(item.toString());
        }
        
    }
}