namespace Calculator;

public class Operation(double value, string operation)
{
    public double one => UpdateValue(1);
    public double two => UpdateValue(2);
    public double three => UpdateValue(3);
    public double four => UpdateValue(4);
    public double five => UpdateValue(5);
    public double six => UpdateValue(6);
    public double seven => UpdateValue(7);
    public double eight => UpdateValue(8);
    public double nine => UpdateValue(9);
    public double ten => UpdateValue(10);

    private double UpdateValue(double newValue) => operation switch
    {
        "+" => value + newValue,
        "-" => value - newValue,
        "*" => value * newValue,
        "/" => value / newValue,
        _ => newValue
    };
}