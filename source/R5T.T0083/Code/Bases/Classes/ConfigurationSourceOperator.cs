using System;


namespace R5T.T0083
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceOperator : IConfigurationSourceOperator
    {
        #region Static
        
        public static ConfigurationSourceOperator Instance { get; } = new();

        #endregion
    }
}