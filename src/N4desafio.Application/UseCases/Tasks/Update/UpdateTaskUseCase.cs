using N4desafio.Communication.Requests;
using N4desafio.Communication.Responses;
using N4desafio.Infrastructure.Request;

namespace N4desafio.Application.UseCases.Tasks.Update
{
    public class UpdateTaskUseCase
    {
        public void Execute(int id, RequestUpdateTask request) 
        {

            DBRequest dbRequest = new DBRequest();
            List<ResponseRegisterTask> alltasks = dbRequest.ReadDB();
            ResponseRegisterTask getTask = alltasks.FirstOrDefault(t => t.Id == id);

            getTask.Title = request.Title;
            getTask.Description = request.Description;
            getTask.Status = request.Status;
            getTask.Priority = request.Priority;

            dbRequest.UpdateDB(alltasks);
        }
    }
}
