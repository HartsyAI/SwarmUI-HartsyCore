using Hartsy.Extensions.Core.WebAPI;
using SwarmUI.Core;
using SwarmUI.Utils;

namespace Hartsy.Extensions.Core
{
    public class HartsyCore : Extension
    {
        public override void OnFirstInit()
        {
            Logs.Debug("HartsyCoreExtension started.");
            ScriptFiles.Add("Assets/hartsyCore.js");
        }

        public override void OnInit()
        {
            HartsyCoreAPI.Register();
        }
    }
}