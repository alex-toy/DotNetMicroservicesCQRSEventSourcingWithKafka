using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class DeletePostCommand : BaseCommand
    {
        public Guid PostId { get; set; }
        public string UserName { get; set; }
    }
}
