// See https://aka.ms/new-console-template for more information
using CommandLine;

public class Options
{
    [Option('b', "bindDir", Required = true, HelpText = "Binary Directory")]
    public string BinaryDirectory { get; set; }

    [Option('t', "text", Required = true, HelpText = "Text (selected class name)")]
    public string ClassName { get; set; }

    [Option('p', "projectName", Required = true, HelpText = "csproj name,")]
    public string ProjectName { get; set; }
}