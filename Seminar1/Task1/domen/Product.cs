class Product {
    private long id;
    private string name;
    private double price;
    private int place;

    public Product(long id, string name, double price, int place) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.place = place;
    }
    public long getId() {
        return id;
    }
    public void setId(long id) {
        this.id = id;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public double getPrice() {
        return price;
    }
    public double getPlace() {
        return place;
    }
    public void setPlace(int place) {
        this.place = place;
    }
    public int GetPrice() {
        return place;
    }
    public String toString() {
        return $"Product [id={id}, name={name}, place={place}, price={price}]";
    }


}