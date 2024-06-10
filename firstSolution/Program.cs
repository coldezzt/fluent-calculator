using firstSolution;

var fluentCalculator = new FluentCalculator();

Console.WriteLine(fluentCalculator.one.plus.three);
Console.WriteLine(6 * fluentCalculator.one.plus.two + 4);
Console.WriteLine(fluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four + 4);
