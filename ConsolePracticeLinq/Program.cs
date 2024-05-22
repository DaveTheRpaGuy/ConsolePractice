// ObjectDumper.NET (4.2.7) kinda weird but kinda works so I don't have to figure out LINQPad right now
// Writing code while watching this video https://www.youtube.com/watch?v=7-P6Mxl5elg&ab_channel=AmichaiMantinband
// Video title: "Every Single LINQ Extension Method With Examples | .NET & C# Essentials

// Comment CTRL+K+C, Uncomment CTRL+K+U

IEnumerable<int> collection1 = [1, 2, 3, 4, 5, 1, 1];
IEnumerable<object> collection2 = [1, "asdf", 2, 3, 4, 5];

#region Filtering

Console.WriteLine(collection1.Dump());
Console.WriteLine();

Console.WriteLine(collection1.Where(x => x > 2).Dump());
Console.WriteLine();

Console.WriteLine(collection2.OfType<int>().Dump());
Console.WriteLine();

Console.WriteLine(collection2.OfType<string>().Dump());
Console.WriteLine();

#endregion

#region Partitioning

Console.WriteLine(collection1.Skip(3).Dump());
Console.WriteLine();

Console.WriteLine(collection1.Take(3).Dump());
Console.WriteLine();

Console.WriteLine(collection1.SkipLast(3).Dump());
Console.WriteLine();

Console.WriteLine(collection1.TakeLast(3).Dump());
Console.WriteLine();

Console.WriteLine(collection1.SkipWhile(x => x < 2).Dump());
Console.WriteLine();

Console.WriteLine(collection1.TakeWhile(x => x < 2).Dump());
Console.WriteLine();

#endregion

#region Projection

Console.WriteLine(collection1.Select(x => x.ToString()).Dump());
Console.WriteLine(collection1.Select((x, i) => $"{i}. {x}").Dump());
// at 5:05 in the video before I threw up in my mouth a little from how kinda boring this is


#endregion


Console.ReadLine();