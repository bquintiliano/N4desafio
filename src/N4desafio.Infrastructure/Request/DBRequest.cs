using N4desafio.Communication.Requests;
using N4desafio.Communication.Responses;
using System.Text.Json;

namespace N4desafio.Infrastructure.Request
{
    public class DBRequest
    {
        private string pathDB = $"{Environment.CurrentDirectory}\\..\\N4desafio.Infrastructure\\DB\\db.json";

        public List<ResponseRegisterTask> ReadDB()
        {
            List<ResponseRegisterTask> tasks = new List<ResponseRegisterTask>();

            var readDB = File.ReadAllBytes(pathDB);

            if (readDB.Length > 0)
                tasks = JsonSerializer.Deserialize<List<ResponseRegisterTask>>(readDB).OrderBy(t => t.Id).ToList();

            return tasks;
        }

        public void WriteDB(List<ResponseRegisterTask> task)
        {
            var convertTask = JsonSerializer.SerializeToUtf8Bytes(task);

            File.WriteAllBytes(pathDB, convertTask);
        }

        public void UpdateDB(List<ResponseRegisterTask> task)
        {
            var convertTask = JsonSerializer.SerializeToUtf8Bytes(task);

            File.WriteAllBytes(pathDB, convertTask);
        }
    }
}
