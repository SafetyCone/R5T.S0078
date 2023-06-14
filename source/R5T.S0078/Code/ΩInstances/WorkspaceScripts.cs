using System;


namespace R5T.S0078
{
    public class WorkspaceScripts : IWorkspaceScripts
    {
        #region Infrastructure

        public static IWorkspaceScripts Instance { get; } = new WorkspaceScripts();


        private WorkspaceScripts()
        {
        }

        #endregion
    }
}
