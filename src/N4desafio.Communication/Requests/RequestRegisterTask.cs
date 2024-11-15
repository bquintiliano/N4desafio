using N4desafio.Communication.Enums;

namespace N4desafio.Communication.Requests
{
    public class RequestRegisterTask
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public PriorityType Priority { get; set; }
        public DateTime LimitDate { get; set; }
        public StatusType Status { get; set; }
    }
}
