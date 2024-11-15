using N4desafio.Communication.Responses;
using N4desafio.Infrastructure.Request;

namespace N4desafio.Application.UseCases.Tasks.Response
{
    public class ResponseOneTaskUseCase
    {
        public ResponseRegisterTask Execute(int id)
        {
            return new DBRequest().ReadDB().FirstOrDefault(t => t.Id == id);
        }
    }
}
