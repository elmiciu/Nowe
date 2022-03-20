using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace XYZExporter
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
        }

        public static async Task<List<string>> ReadFileAsync(string path)
        {
            try
            {
                if (!File.Exists(path)) throw new FileNotFoundException($"Plik {path} nie istnieje");
                var file = await File.ReadAllLinesAsync(path);
                return new List<string>(file);
            }
            catch (FileNotFoundException e)
            {
                await LogToFileAsync("log.txt", e.Message);
                throw;
            }
            catch (Exception)
            {
                await LogToFileAsync("log.txt", "Błąd podczas zapisu pliku");
                throw;
            }
        }

        public static async Task SaveFileAsync(string path, string content)
        {
            try
            {
                await File.WriteAllTextAsync(path, content);
            }
            catch (Exception)
            {
                await LogToFileAsync("log.txt", "Błąd podczas zapisu pliku");
                throw;
            }
        }

        public static async Task LogToFileAsync(string path, string content)
        {
            try
            {
                await File.AppendAllTextAsync(path, content);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
