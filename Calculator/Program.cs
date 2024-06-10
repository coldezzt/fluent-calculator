using Calculator;

var fluentCalculator = new Operation(0, "");

Console.WriteLine(123 + fluentCalculator.one.plus().five - 23123.4234);
Console.WriteLine(fluentCalculator.one.plus().two);
Console.WriteLine(fluentCalculator.one.plus().two.plus().three.minus().one.minus().two.minus().four.dividedBy().nine);
