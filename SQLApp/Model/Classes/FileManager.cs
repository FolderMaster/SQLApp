using System.IO;
using Newtonsoft.Json;

namespace SQLApp.Model.Classes
{
    public static class FileManager<T>
    {
        public static T Load(string filePath)
        {
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        public static void Save(T item, string filePath)
        {
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create))
            {
                string text = JsonConvert.SerializeObject(item);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}
