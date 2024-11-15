using N4desafio.Communication.Responses;
using N4desafio.Infrastructure.Request;

namespace N4desafio.Application.UseCases.Tasks.Delete
{
    public class DeleteTaskUseCase
    {
        public void Execute(int id)
        {
            DBRequest dbRequest = new DBRequest();
            List<ResponseRegisterTask> alltasks = dbRequest.ReadDB();
            ResponseRegisterTask getTask = alltasks.FirstOrDefault(t => t.Id == id);

            if(getTask != null) 
                alltasks.Remove(getTask);

            dbRequest.UpdateDB(alltasks);
        }
    }
}
