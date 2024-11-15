using N4desafio.Communication.Requests;
using N4desafio.Communication.Responses;
using N4desafio.Infrastructure.Request;

namespace N4desafio.Application.UseCases.Tasks.Register
{
    public class RegisterTaskUseCase
    {
        public void Execute(RequestRegisterTask request)
        {
            var dbRequest = new DBRequest();

            var allTask = dbRequest.ReadDB();

            int id = 1;

            if (allTask.Count > 0)
                id = allTask.LastOrDefault().Id + 1;

            ResponseRegisterTask task = new ResponseRegisterTask
            {
                Id = id,
                Title = request.Title,
                Description = request.Description,
                Priority = request.Priority,
                LimitDate = request.LimitDate,
                Status = request.Status
            };

            allTask.Add(task);

            dbRequest.WriteDB(allTask);
        }
    }
}
