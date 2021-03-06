namespace OpenQA.Selenium.DevTools.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overriden Geolocation Position and Error.
    /// </summary>
    public sealed class ClearGeolocationOverrideCommandSettings : ICommand
    {
        private const string DevToolsRemoteInterface_CommandName = "Page.clearGeolocationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return DevToolsRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearGeolocationOverrideCommandResponse : ICommandResponse<ClearGeolocationOverrideCommandSettings>
    {
    }
}