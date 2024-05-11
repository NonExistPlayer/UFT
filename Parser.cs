using System.Xml.Linq;
using static UFT.Program;

namespace UFT;

#pragma warning disable CS8602

public static class UFTHost
{
    public static void CreateFile(string PathToTemplate, string PathToNewFile)
    {
        if (!PathToTemplate.Contains('.')) PathToTemplate += ".uft";
        if (!File.Exists(PathToTemplate)) Error("file does not exist.");
        string[] file = File.ReadAllLines(PathToTemplate);
        for (int i = 0; i < file.Length; i++)
        {
            file[i] = file[i].Replace("<name>", Path.GetFileNameWithoutExtension(PathToNewFile));
            file[i] = file[i].Replace("<path>", Path.GetFullPath(PathToNewFile));
        }
        XDocument doc = XDocument.Parse(string.Join('\n', file));
        XElement? output = doc.Root;
        if (output == null) Error("bad uft. (element: output)");
        string? newName = null;
        if (output.Attribute("name") != null)
            newName = output.Attribute("name").Value;
        XAttribute? output_ext = output.Attribute("extension");
        if (output_ext == null) Error("bad uft. (attribute: output extension)");

        File.WriteAllLines(
            (newName == null ? PathToNewFile : Path.GetDirectoryName(PathToNewFile) + newName) + output_ext.Value,
            output.Value.Split('\n')[1..
            (output.Value.Split('\n').Length - (string.IsNullOrWhiteSpace(output.Value) ? 0 : 1))
            ]
        );
    }
    public static void CreateTemplate(string PathToTemplate)
    {
        File.WriteAllText(PathToTemplate, @"<output extension="".txt"">
Name of file: <name>
Path to file: <path>
</output>
");
    }
}