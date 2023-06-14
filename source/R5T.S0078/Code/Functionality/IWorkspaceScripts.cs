using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0078
{
    [FunctionalityMarker]
    public partial interface IWorkspaceScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Open a C# project file.
        /// This is a basic hello-world operation for Roslyn workspaces.
        /// </summary>
        public async Task OpenProject()
        {
            /// Inputs.
            var projectFilePath =
                Instances.ProjectFilePaths.Example_SimpleWithProjectReference
                ;


            /// Run.
            await Instances.WorkspaceOperator.In_WorkspaceContext(
                async workspace =>
                {
                    var project = await workspace.OpenProjectAsync(projectFilePath.Value);

                    Console.WriteLine($"{project.Language}: language");
                });
        }
    }
}
