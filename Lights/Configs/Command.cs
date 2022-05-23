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
        [Description("����������ơ�")]
        public string Name { get; set; } = "lightsre";

        /// <summary>
        /// Gets or sets all accepted command aliases.
        /// </summary>
        [Description("������ı�����")]
        public string[] Aliases { get; set; } = { "lights", "lre", "ls" };

        /// <summary>
        /// Gets or sets the command description.
        /// </summary>
        [Description("�������������")]
        public string Description { get; set; } = "�������������ʹ��Ԥ���޸ķ���/�����ĵƹ⣡";

        /// <summary>
        /// Gets or sets the command usage info.
        /// </summary>
        [Description("�������ʹ����Ϣ��")]
        public string[] Usage { get; set; } = { "PresetID" };
    }
}