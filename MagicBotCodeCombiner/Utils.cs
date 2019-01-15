using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MagicBotCodeCombiner
{
    public static class Utils
    {
        public static string GetBaseDirectory(string sourceAssemblyName)
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var assemblyDirectoty = Path.GetDirectoryName(path);
            var combinerCodeDirectory = Path.GetFullPath(Path.Combine(assemblyDirectoty, @"..\..\..\"));
            var result = Path.Combine(combinerCodeDirectory, sourceAssemblyName);

            return result;
        }

        public static string GetFileList(string baseDirectory)
        {
            var result = string.Empty;
            var sourceFileList = FindAllCsFiles(baseDirectory);

            for (var i = 0; i < sourceFileList.Count; i++)
            {
                var fileName = sourceFileList[i].Substring(baseDirectory.Length,
                    sourceFileList[i].Length - baseDirectory.Length);
                result = result + fileName + Environment.NewLine;
            }

            return result.Trim();
        }

        public static Tuple<string, string> GetCombinedFileText(string baseDirectory, string fileList)
        {
            var fullCodeText = string.Empty;
            var usingText = string.Empty;
            var usingsList = new HashSet<string>();

            using (var fileListReader = new StringReader(fileList))
            {
                string fileName;
                while ((fileName = fileListReader.ReadLine()) != null)
                {
                    var fileText = System.IO.File.ReadAllText(baseDirectory + fileName);

                    var codeText = string.Empty;

                    using (var fileContentReader = new StringReader(fileText))
                    {
                        // getting all usings
                        string line;
                        while ((line = fileContentReader.ReadLine()) != null)
                        {
                            if (line.StartsWith("using "))
                            {
                                usingsList.Add(line);
                            }
                            else
                            {
                                codeText = codeText + line + Environment.NewLine;
                                break;
                            }
                        }

                        while ((line = fileContentReader.ReadLine()) != null)
                        {
                            codeText = codeText + line + Environment.NewLine;
                        }
                    }

                    fullCodeText = fullCodeText + codeText + Environment.NewLine;
                }
            }

            foreach (var usings in usingsList)
            {
                usingText = usingText + usings + Environment.NewLine;
            }            

            return new Tuple<string, string>(usingText, fullCodeText);
        }

        private static List<string> FindAllCsFiles(string baseDir)
        {
            var files = Directory.GetFiles(baseDir, "*.cs", SearchOption.AllDirectories);
            var result = files.ToList();
            result.RemoveAll(x => x.StartsWith(baseDir + @"\obj"));

            return result;
        }
    }
}
