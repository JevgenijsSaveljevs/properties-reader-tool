// See https://aka.ms/new-console-template for more information
using CommandLine;
using System.Reflection;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(o =>
    {
        Console.WriteLine($"Binary Path: {o.BinaryDirectory}");
        Console.WriteLine($"ProjectName: {o.ProjectName}");
        Console.WriteLine($"Class/Struct Name: {o.ClassName}");

        var projectName = o.ProjectName.Trim();
        if (projectName.EndsWith(".csproj"))
        {
            projectName = projectName.Substring(0, projectName.Length - ".csproj".Length);
            projectName += ".dll";
        }

        var asm = Assembly.LoadFrom(o.BinaryDirectory + projectName);
        var type = asm.GetType(o.ClassName);

        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
    });