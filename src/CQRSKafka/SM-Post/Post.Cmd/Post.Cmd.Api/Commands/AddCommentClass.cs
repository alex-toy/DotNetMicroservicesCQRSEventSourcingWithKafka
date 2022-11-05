using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentClass : BaseCommand
    {
        public string Comment { get; set; }
        public string UserName { get; set; }
    }
}
