class Bottle : Product
{
    private double volume;

    public Bottle(long id, string name, double price, int place, double volume) : base(id, name, price, place)
    {
        this.volume = volume;
    }

    public void setVolume(double volume) {
        this.volume = volume;
    }

    public double getVolume() {
        return volume;
    }

    public string toString()
    {
        return $"Bottle [{base.toString()}, volume={volume}]";
    }
}