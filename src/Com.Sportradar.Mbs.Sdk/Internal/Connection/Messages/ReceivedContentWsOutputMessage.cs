using Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

namespace Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages;

internal class ReceivedContentWsOutputMessage : WsOutputMessage
{
    public ReceivedContentWsOutputMessage(string content)
        : base("")
    {
        Content = content;
    }

    internal string Content { get; }
}