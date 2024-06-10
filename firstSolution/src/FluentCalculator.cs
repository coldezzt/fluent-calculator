namespace firstSolution;

public class FluentCalculator
{
    private Operation Operator = Operation.Undefined;
    
    private double Value;

    public FluentCalculator one => UpdateValue(1);
    public FluentCalculator two => UpdateValue(2);
    public FluentCalculator three => UpdateValue(3);
    public FluentCalculator four => UpdateValue(4);
    public FluentCalculator five => UpdateValue(5);
    public FluentCalculator six => UpdateValue(6);
    public FluentCalculator seven => UpdateValue(7);
    public FluentCalculator eight => UpdateValue(8);
    public FluentCalculator nine => UpdateValue(9);
    public FluentCalculator ten => UpdateValue(10);

    public FluentCalculator plus => SetOperator(Operation.Plus);
    public FluentCalculator minus => SetOperator(Operation.Minus);
    public FluentCalculator dividedBy => SetOperator(Operation.Divide);
    public FluentCalculator times => SetOperator(Operation.Times);
    
    private FluentCalculator UpdateValue(double newValue)
    {
        if (Operator is Operation.Unset) 
            throw new InvalidOperationException("Can't handle two numbers at the same time");
        
        Value = Operator switch
        {
            Operation.Plus => Value += newValue,
            Operation.Minus => Value -= newValue,
            Operation.Times => Value *= newValue,
            Operation.Divide => Value /= newValue,
            _ => newValue
        };

        Operator = Operation.Unset;
        return this;
    }

    private FluentCalculator SetOperator(Operation op)
    {
        if (Operator is not Operation.Unset)
            throw new InvalidOperationException("Can't handle two operators at the same time");
        
        Operator = op;
        return this;
    }

    public static implicit operator double(FluentCalculator fc)
    {
        if (fc.Operator is not Operation.Unset)
            throw new InvalidOperationException("Call sequence should end on value, not operation");

        var result = fc.Value;
        fc.Value = 0;
        fc.Operator = Operation.Undefined;
        return result;
    }
}