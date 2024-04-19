using ClassLibrary1;

var class1 = new Class1();

// test (expired) token
var secret = "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";

Console.WriteLine(class1.GetMessage());
Console.ReadKey();
