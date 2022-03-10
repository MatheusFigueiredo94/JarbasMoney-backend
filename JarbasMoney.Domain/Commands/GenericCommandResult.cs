using JarbasMoney.Domain.Commands.Contracts;

namespace JarbasMoney.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string message, object content)
        {
            Success = success;
            Message = message;
            Content = content;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Content { get; set; }
    }
}
