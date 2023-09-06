// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// print 9*9
for (int i=1;i<=9;i++){
    for (int j=1;j<=i;j++){
        Console.Write("{0}*{1}={2}\t",j,i,i*j);
    }
    Console.WriteLine();
}