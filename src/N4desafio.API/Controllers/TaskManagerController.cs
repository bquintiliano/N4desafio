using Microsoft.AspNetCore.Mvc;
using N4desafio.Application.UseCases.Tasks.Delete;
using N4desafio.Application.UseCases.Tasks.Register;
using N4desafio.Application.UseCases.Tasks.Response;
using N4desafio.Application.UseCases.Tasks.Update;
using N4desafio.Communication.Requests;
using N4desafio.Communication.Responses;

namespace N4desafio.API.Controllers
{
    public class TaskManagerController : N4desafioBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseRegisterTask>), StatusCodes.Status200OK)]
        public IActionResult GetTasks()
        {
            var result =  new ResponseTaskUseCase().Execute();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseRegisterTask), StatusCodes.Status200OK)]
        public IActionResult GetTasksById(int id)
        {
            var result = new ResponseOneTaskUseCase().Execute(id);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult PostTask(RequestRegisterTask request)
        {
            new RegisterTaskUseCase().Execute(request);
            return Created();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PutTask(int id, RequestUpdateTask request)
        {
            new UpdateTaskUseCase().Execute(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteTask(int id)
        {
            new DeleteTaskUseCase().Execute(id);
            return Ok();
        }
    }
}
