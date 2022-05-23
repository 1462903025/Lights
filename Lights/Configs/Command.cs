// -----------------------------------------------------------------------
// <copyright file="Command.cs" company="Beryl">
// Copyright (c) Beryl. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Lights.Configs
{
    using System.ComponentModel;

    /// <summary>
    /// Configs relating to the plugin's <see cref="Commands.Lights"/> command.
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Gets or sets the main command name.
        /// </summary>
        [Description("主命令的名称。")]
        public string Name { get; set; } = "lightsre";

        /// <summary>
        /// Gets or sets all accepted command aliases.
        /// </summary>
        [Description("主命令的别名。")]
        public string[] Aliases { get; set; } = { "lights", "lre", "ls" };

        /// <summary>
        /// Gets or sets the command description.
        /// </summary>
        [Description("主命令的描述。")]
        public string Description { get; set; } = "根据您的输入或使用预设修改房间/分区的灯光！";

        /// <summary>
        /// Gets or sets the command usage info.
        /// </summary>
        [Description("主命令的使用信息。")]
        public string[] Usage { get; set; } = { "PresetID" };
    }
}