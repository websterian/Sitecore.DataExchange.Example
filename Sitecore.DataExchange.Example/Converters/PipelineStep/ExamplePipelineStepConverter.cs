// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExampleEndpointConverter.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ExampleEndpointConverter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.DataExchange.Example.Converters.PipelineStep
{
    using Sitecore.DataExchange.Converters.PipelineSteps;
    using Sitecore.DataExchange.Models;
    using Sitecore.DataExchange.Repositories;
    using Sitecore.Services.Core.Model;

    /// <summary>
    /// The example endpoint converter.
    /// </summary>
    public class ExampleEndpointConverter : DefaultPipelineStepConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleEndpointConverter"/> class.
        /// </summary>
        /// <param name="repository">
        /// The repository.
        /// </param>
        public ExampleEndpointConverter(IItemModelRepository repository) : base(repository)
        {
        }

        /// <summary>
        /// The add plugins.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="pipelineStep">
        /// The pipeline Step.
        /// </param>
        protected override void AddPlugins(ItemModel source, PipelineStep pipelineStep)
        {
            var settings = new ExampleSettings();

            var endpointFrom = this.ItemModelRepository.Get(new System.Guid(source["EndpointFrom"].ToString()));
            if (endpointFrom != null)
            {
                settings.CreatePath = endpointFrom["Create path"].ToString();
            }

            pipelineStep.Plugins.Add(settings);
        }
    }
}
