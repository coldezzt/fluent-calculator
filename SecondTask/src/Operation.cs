namespace SecondTask;

public class Operation(double value = 0, string operation = "")
{
    public Value one => UpdateValue(1);
    public Value two => UpdateValue(2);
    public Value three => UpdateValue(3);
    public Value four => UpdateValue(4);
    public Value five => UpdateValue(5);
    public Value six => UpdateValue(6);
    public Value seven => UpdateValue(7);
    public Value eight => UpdateValue(8);
    public Value nine => UpdateValue(9);
    public Value ten => UpdateValue(10);

    private Value UpdateValue(double newValue) => operation switch
    {
        "+" => new Value(value + newValue),
        "-" => new Value(value - newValue),
        "*" => new Value(value * newValue),
        "/" => new Value(value / newValue),
        _ => new Value(newValue)
    };
}