// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: HttpMessage1Handler862252953
    public class HttpMessage1Handler862252953 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var httpMessage1 = (WolverineWebApi.HttpMessage1)context.Envelope.Message;
            WolverineWebApi.MessageHandler.Handle(httpMessage1);
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: HttpMessage1Handler862252953
    
    
}

