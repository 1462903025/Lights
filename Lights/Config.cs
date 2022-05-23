// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Beryl">
// Copyright (c) Beryl. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Lights
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;
    using Lights.Configs;

    /// <inheritdoc cref="IConfig"/>
    public class Config : IConfig
    {
        /// <inheritdoc />
        [Description("是否启用此插件。")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether some debug messages will be shown.
        /// </summary>
        [Description("是否显示一些调试消息。")]
        public bool Debug { get; set; } = true;

        /// <inheritdoc cref="Configs.Command"/>
        [Description("与此插件命令相关的所有配置设置。")]
        public Command Command { get; set; } = new Command();

        /// <inheritdoc cref="Configs.Cassie"/>
        [Description("运行预设时与Cassie相关的所有配置设置。")]
        public Cassie Cassie { get; set; } = new Cassie();
        /*/// <inheritdoc cref="Configs.Broadcasts"/>
        public Broadcasts Broadcasts { get; set; } = new Broadcasts();*/

        /// <inheritdoc cref="Configs.TeslaGates"/>
        [Description("停电、锁定和其他灯光设置期间与特斯拉门相关的所有配置设置。")]
        public TeslaGates TeslaGates { get; set; } = new TeslaGates();

        /// <inheritdoc cref="Configs.Presets"/>
        [Description("该插件的主要功能是预设有乐趣 :)")]
        public Presets Presets { get; set; } = new Presets();
    }
}