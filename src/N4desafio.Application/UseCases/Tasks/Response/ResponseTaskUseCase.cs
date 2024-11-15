using N4desafio.Communication.Responses;
using N4desafio.Infrastructure.Request;

namespace N4desafio.Application.UseCases.Tasks.Response
{
    public class ResponseTaskUseCase
    {
        public List<ResponseRegisterTask> Execute()
        {
            var dbRequest = new DBRequest();
            return dbRequest.ReadDB();
        }
    }
}
