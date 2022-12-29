using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CSharpSharedData
{
    public class TimedComponentBase : ComponentBase
    {
        [Inject] private ILogger<TimedComponentBase> Logger { get; set; }
        private readonly Stopwatch stopwatch = new();


        protected override void OnParametersSet()
        {
            // Required for the first render where ShouldRender is not called
            stopwatch.Restart();
            base.OnParametersSet();
        }


        protected override bool ShouldRender()
        {
            stopwatch.Restart();
            return base.ShouldRender();
        }


        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            Logger.LogError($"{GetType().FullName} render timing: {stopwatch.ElapsedMilliseconds:N0} ms");
        }
    }
}
