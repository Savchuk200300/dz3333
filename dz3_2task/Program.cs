using System;

class Converter
{
    public Converter(double dollar, double euro)
    {
        this.dollar = dollar;
        this.euro = euro;
    }
    double dollar;
    double euro;

    public double dollarToHrv(double d)
    {
        return d * dollar;
    }
    public double euroToHrv(double e)
    {
        return e * euro;
    }
    public double hrvToDollar(double h)
    {
        return h / dollar;
    }
    public double hrvToEuro(double h)
    {
        return h / euro;
    }

}
namespace dz3_2task
{

    class Program
    {
        static void Main(string[] args)
        {
            Converter C = new Converter(27, 32);
            Console.WriteLine(C.dollarToHrv(15));
            Console.WriteLine(C.euroToHrv(20));
            Console.WriteLine(C.hrvToEuro(13742));
        }
    }
}