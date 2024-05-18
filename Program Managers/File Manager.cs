using System.IO;

namespace App.API;

class FileManager {
    public static void CreateFile(string path, bool overwrite = false) {
        if (overwrite) File.Create(path).Close();
        else if (!File.Exists(path)) File.Create(path).Close();
    }

    public static void OverwriteToFile(string path, string[] content) {
        File.WriteAllLines(path, content);
    }

    public static void WriteToFile(string path, string content, int? line) {
        if (line is not null) {
            // Overwrite a specific line only and keep the rest of the file
            var lines = File.ReadAllLines(path);
            lines[line.Value] = content;
            File.WriteAllLines(path, lines);
        }
        else {
            using StreamWriter sw = File.AppendText(path);
            sw.WriteLine(content);
        }
    }

    public static void AppendToFile(string path, string content) {
        using StreamWriter sw = File.AppendText(path);
        sw.WriteLine(content);
    }

    public static string[] ReadFromFile(string path) {
        CreateFile(path);
        var lines = File.ReadAllLines(path);
        return lines;
    }
}