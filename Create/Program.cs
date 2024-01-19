// See https://aka.ms/new-console-template for more information
using Create;
CreateFolder cf;
DeleteFolder df;
DeleteFile dff;
AddFile af;
Console.WriteLine(" choose the operation");
Console.WriteLine("a: create new folder");
Console.WriteLine("b: create new file ");
Console.WriteLine("c: delete folder ");
Console.WriteLine("d: delete file");
String choose=Console.ReadLine();
if ( choose == "a")
{
    Console.WriteLine("please enter folder name");
    String name = Console.ReadLine();
    if (!Directory.Exists(name))
    {
        cf = new CreateFolder(name);
        Console.WriteLine(" Done : the " + name + " folder is created");
    }
    else Console.WriteLine(" this folder is already exist");
}
else if (choose == "b")
{
    Console.WriteLine("Please enter the file name");
    String s=Console.ReadLine();
    if (!File.Exists(s))
    {
        af = new AddFile(s);
        Console.WriteLine(s + " file is created");
    }
    else Console.WriteLine(s + " file is already exist");
    
}
else if (choose == "c")
{
    Console.WriteLine("please enter folder name");
    String name = Console.ReadLine();
    if (Directory.Exists(name))
    {
        df = new DeleteFolder(name);
        Console.WriteLine(" Done " + name + " file is deleted");
    }
    else
        Console.WriteLine(name + " is already not exist");
}
else if (choose == "d")
{
    Console.WriteLine("please enter the file name");
    String name = Console.ReadLine();
    if (File.Exists(name))
    {
        dff = new DeleteFile(name);
        Console.WriteLine("Done :  "+ name + " file is deleted");
    }
    else
        Console.WriteLine(name + " file is already not exist");
}
else
{
    Console.WriteLine("Invalid Choice");
}


