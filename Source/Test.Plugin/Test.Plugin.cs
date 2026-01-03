using System;
using System.Collections.Generic;
using System.Text;
using ContentTypeTextNet.Pe.Bridge.Plugin;
using ContentTypeTextNet.Pe.Bridge.Plugin.Addon;
using ContentTypeTextNet.Pe.Bridge.Plugin.Preferences;
using ContentTypeTextNet.Pe.Embedded.Abstract;

namespace Test.Plugin
{
    public class Plugin: PluginBase// IAddon, ITheme, IPreferences
    {
        #region variable
        #endregion

        public Plugin(IPluginConstructorContext pluginConstructorContext)
            : base(pluginConstructorContext)
        {
            //
        }

        #region PluginBase

        protected override void InitializeImpl(IPluginInitializeContext pluginInitializeContext)
        { }

        protected override void FinalizeImpl(IPluginFinalizeContext pluginFinalizeContext)
        { }

        #endregion

    }
}
