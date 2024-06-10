namespace FirstTask;

public class CustomBool(bool value = false)
{
    private readonly bool _value = value;
    
    public static bool operator ==(CustomBool left, bool right) => true;
    
    public static bool operator !=(CustomBool left, bool right) => left == right;

    public static implicit operator bool(CustomBool c) => c._value;
}