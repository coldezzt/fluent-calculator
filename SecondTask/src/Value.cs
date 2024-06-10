namespace SecondTask;

public class Value(double n)
{
    private double Result { get; } = n;
    
    public Operation plus => SetOperator("+");
    public Operation minus => SetOperator("-");
    public Operation dividedBy => SetOperator("/");
    public Operation times => SetOperator("*");
    
    private Operation SetOperator(string op) => new(Result, op);

    public static implicit operator double(Value v) => v.Result;
}