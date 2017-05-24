﻿namespace Core7.Headers
{
    using System.Threading.Tasks;
    using NServiceBus;

    #region header-incoming-handler
    public class ReadHandler :
        IHandleMessages<MyMessage>
    {
        public async Task Handle(MyMessage message, IMessageHandlerContext context)
        {
            var headers = context.MessageHeaders;
            var nsbVersion = headers[Headers.NServiceBusVersion];
            var customHeader = headers["MyCustomHeader"];
        }
    }
    #endregion
}
