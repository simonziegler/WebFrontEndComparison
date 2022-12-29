using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CSharpSharedData
{
    public class TimedComponentBase : ComponentBase
    {
        [Inject] private ILogger<TimedComponentBase> Logger { get; set; } = default!;
        protected readonly Stopwatch RenderStopwatch = new();


        protected override void OnInitialized()
        {
            // Required for the first render where ShouldRender is not called
            RenderStopwatch.Restart();
            base.OnInitialized();
        }


        protected override bool ShouldRender()
        {
            if (!RenderStopwatch.IsRunning)
            {
                RenderStopwatch.Restart();
            }

            return base.ShouldRender();
        }


        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            Logger.LogError($"{GetType().FullName} render timing: {RenderStopwatch.ElapsedMilliseconds:N0} ms");
            RenderStopwatch.Reset();
        }
    }
}
