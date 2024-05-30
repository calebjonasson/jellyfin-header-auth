using System;
using System.Collections.Generic;
using Jellyfin.Plugin.JellyfinHeaderAuth.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.JellyfinHeaderAuth;

public class HeaderAuthPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public HeaderAuthPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public static HeaderAuthPlugin Instance { get; private set; }

    public override string Name => "Jellyfin-Header-Auth";

    public override Guid Id => Guid.Parse("aa50c76e-63c6-4479-97e4-18299a29a3bb");

    public IEnumerable<PluginPageInfo> GetPages()
    {
        yield return new PluginPageInfo
        {
            Name = Name,
            EmbeddedResourcePath = $"{GetType().Namespace}.Config.configPage.html"
        };
    }
}
