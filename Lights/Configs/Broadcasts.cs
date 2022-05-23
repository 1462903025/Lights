// -----------------------------------------------------------------------
// <copyright file="Broadcasts.cs" company="Beryl">
// Copyright (c) Beryl. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Lights.Configs
{
    using System.ComponentModel;
    using Exiled.API.Features;

    /// <summary>
    /// Configs relating to how broadcasts should be handled during a blackout.
    /// </summary>
    public class Broadcasts
    {
        /// <summary>
        /// Gets or sets a value indicating whether a broadcast should be shown when the lights are turned off.
        /// </summary>
        [Description("灯光关闭时是否应显示广播。")]
        public bool DoBroadcastMessage { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether broadcasts should be cleared prior to this one being shown.
        /// </summary>
        [Description("是否应在播放此广播之前清除广播。")]
        public bool ClearBroadcasts { get; set; } = true;

        /// <summary>
        /// Gets or sets the broadcast shown when the lights are only turned off in <see cref="Exiled.API.Enums.ZoneType.HeavyContainment"/>.
        /// </summary>
        [Description("仅在重型收容区域关闭灯时显示的广播。（%ss=停电持续时间）")]
        public Broadcast HczOnly { get; set; } = new Broadcast("<color=aqua>灯光已关闭 %ss 秒！芜湖！</color>", 5);

        /// <summary>
        /// Gets or sets the broadcast shown when the lights are turned off in the entire facility.
        /// </summary>
        [Description("当整个设施内的灯关闭时显示的广播。（%ss=停电持续时间）")]
        public Broadcast Both { get; set; } = new Broadcast("<color=aqua>灯光已关闭 %ss 秒！芜湖!</color>", 5);
    }
}