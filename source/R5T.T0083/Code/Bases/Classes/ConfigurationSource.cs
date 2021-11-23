using System;


namespace R5T.T0083
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSource : IConfigurationSource
    {
        #region Static
        
        public static ConfigurationSource Instance { get; } = new();

        #endregion
    }
}