namespace Calculator;

public static class DoubleExtensions
{
    public static Operation plus(this double value) => new(value, "+");
    public static Operation minus(this double value) => new(value, "-");
    public static Operation dividedBy(this double value) => new(value, "/");
    public static Operation times(this double value) => new(value, "*");
}