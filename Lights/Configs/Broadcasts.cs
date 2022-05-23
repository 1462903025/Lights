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
        [Description("�ƹ�ر�ʱ�Ƿ�Ӧ��ʾ�㲥��")]
        public bool DoBroadcastMessage { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether broadcasts should be cleared prior to this one being shown.
        /// </summary>
        [Description("�Ƿ�Ӧ�ڲ��Ŵ˹㲥֮ǰ����㲥��")]
        public bool ClearBroadcasts { get; set; } = true;

        /// <summary>
        /// Gets or sets the broadcast shown when the lights are only turned off in <see cref="Exiled.API.Enums.ZoneType.HeavyContainment"/>.
        /// </summary>
        [Description("����������������رյ�ʱ��ʾ�Ĺ㲥����%ss=ͣ�����ʱ�䣩")]
        public Broadcast HczOnly { get; set; } = new Broadcast("<color=aqua>�ƹ��ѹر� %ss �룡�ߺ���</color>", 5);

        /// <summary>
        /// Gets or sets the broadcast shown when the lights are turned off in the entire facility.
        /// </summary>
        [Description("��������ʩ�ڵĵƹر�ʱ��ʾ�Ĺ㲥����%ss=ͣ�����ʱ�䣩")]
        public Broadcast Both { get; set; } = new Broadcast("<color=aqua>�ƹ��ѹر� %ss �룡�ߺ�!</color>", 5);
    }
}