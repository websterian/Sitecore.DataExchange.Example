// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateSomeItems.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CreateSomeItems type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.DataExchange.Example.Processors.PipelineSteps
{
    using Sitecore.DataExchange.Contexts;
    using Sitecore.DataExchange.Example.Converters.PipelineStep;
    using Sitecore.DataExchange.Models;
    using Sitecore.DataExchange.Processors.PipelineSteps;

    /// <summary>
    /// The create some items.
    /// </summary>
    public class CreateSomeItems : BasePipelineStepProcessor
    {
        /// <summary>
        /// The process.
        /// </summary>
        /// <param name="pipelineStep">
        /// The pipeline step.
        /// </param>
        /// <param name="pipelineContext">
        /// The pipeline context.
        /// </param>
        public override void Process(PipelineStep pipelineStep, PipelineContext pipelineContext)
        {
            var exampleSettings = pipelineStep.GetPlugin<ExampleSettings>();
            if (exampleSettings != null)
            {
                pipelineContext.PipelineBatchContext.Logger.Info(
                    "Hello world! Create some items here..." + exampleSettings.CreatePath);
            }
        }
    }
}
