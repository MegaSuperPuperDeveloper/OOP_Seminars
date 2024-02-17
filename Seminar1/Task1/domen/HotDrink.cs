class HotDrink : Product {
    private double temp;

    public HotDrink(long id, string name, double price, int place, double temp) : base(id, name, price, place)
    {
        this.temp = temp;
    }

    public void setTemp(double temp) {
        this.temp = temp;
    }

    public double getTemp() {
        return temp;
    }

    public string toString() {
        return $"HotDrink [{base.toString()}, temp={temp}]";
    }



}