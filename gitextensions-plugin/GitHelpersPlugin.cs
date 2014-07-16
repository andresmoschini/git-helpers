using GitUIPluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHelpers
{
    public class GitHelpersPlugin : GitPluginBase, IGitPluginForRepository
    {
        protected override void RegisterSettings()
        {
            base.RegisterSettings();
            Settings.AddSetting("Git remote repo associated to TFS", "upstream");
            Settings.AddSetting("TFS remote name", "tfs");
            Settings.AddSetting("TFS:Git branches mapping (comma separated)", "default:develop, integration:integration, qa:qa");
        }
        
        public override string Description
        {
            get { return "Git Helpers"; }
        }

        public override bool Execute(GitUIBaseEventArgs gitUiArgs)
        {
            gitUiArgs.GitUICommands.StartSettingsDialog(this);
            return false;
        }

    }
}
