// -----------------------------------------------------------------------
// <copyright file="Cassie.cs" company="Beryl">
// Copyright (c) Beryl. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Lights.Configs
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Enums;

    /// <summary>
    /// Configs relating to how cassie should be handled during a blackout.
    /// </summary>
    public class Cassie
    {
        /// <summary>
        /// Gets or sets a value indicating whether Cassie should announce when the lights are affected.
        /// </summary>
        [Description("ָʾCassie�Ƿ�Ӧ�ڵƹ��ܵ�Ӱ��ʱ������")]
        public bool DoCassieMessages { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the cassie announcement should be held.
        /// </summary>
        [Description("ָʾ�Ƿ�Ӧ���� cassie ���档")]
        public bool MakeHold { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the cassie announcement should have background noise.
        /// </summary>
        [Description("ָʾ cassie �����Ƿ�Ӧ�б���������")]
        public bool MakeNoise { get; set; } = false;

        /// <summary>
        /// Gets or sets what cassie says when a preset is used.
        /// </summary>
        [Description("cassie��˵��ȡ������ʹ�õ�Ԥ�衣��%ss=Ӱ�����ʱ�䣩")]
        public Dictionary<string, string> Messages { get; set; } = new Dictionary<string, string>()
        {
            { "myZonePreset1", "generator .g3 malfunction detected .g4 .g3 .g3 .g4" },
            { "myZonePreset2", "heavy containment zone generator .g3 malfunction detected .g4 .g3 .g3 .g4" },
        };
    }
}