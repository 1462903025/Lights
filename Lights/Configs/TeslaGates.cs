// -----------------------------------------------------------------------
// <copyright file="TeslaGates.cs" company="Beryl">
// Copyright (c) Beryl. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Lights.Configs
{
    using System.ComponentModel;

    /// <summary>
    /// Configs relating <see cref="TeslaGate">Tesla Gates</see> during blackouts, lockdowns and other light settings.
    /// </summary>
    public class TeslaGates
    {
        /// <summary>
        /// Gets or sets whether teslas will be disabled when below a certain light intensity level.
        /// </summary>
        [Description("特斯拉门功能所需的最小强度。")]
        public float IntensityMinimum { get; set; } = 0.7f;

        /// <summary>
        /// Gets or sets a value indicating whether teslas will be disabled during a lockdown.
        /// </summary>
        [Description("特斯拉大门是否会在封锁期间保持功能。")]
        public bool DisableOnLockdown { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether teslas will be disabled during a lockdown.
        /// </summary>
        [Description("特斯拉大门是否会在封锁期间保持功能。")]
        public bool DisableOnBlackout { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether tesla gates will be affected if their light settings change from other plugins. (EXPERIMENTAL)
        /// </summary>
        [Description("如果特斯拉安全点房间的灯光设置被其他插件/命令更改，特斯拉安全点房间是否会受到影响。 (实验性)")]
        public bool SmartGates { get; set; } = true;

        /// <inheritdoc cref="RGBSettings"/>
        public RGBSettings ColorSettings { get; set; } = new RGBSettings();

        /// <inheritdoc cref="TeslaGates"/>
        public class RGBSettings
        {
            /// <summary>
            /// Gets or sets whether teslas will be disabled when below a certain red value.
            /// </summary>
            [Description("特斯拉闸门正常工作所需的最小红色值。")]
            public float R { get; set; } = 95f;

            /// <summary>
            /// Gets or sets whether teslas will be disabled when below a certain green value.
            /// </summary>
            [Description("特斯拉门正常工作所需的最小绿色值。")]
            public float G { get; set; } = 95f;

            /// <summary>
            /// Gets or sets whether teslas will be disabled when below a certain blue value.
            /// </summary>
            [Description("特斯拉门正常工作所需的最低蓝色值。")]
            public float B { get; set; } = 95f;

            /// <summary>
            /// Gets or sets a value indicating whether all color values must be below their minimum before getting disabled.
            /// </summary>
            [Description("禁用之前，所有颜色值是否必须低于其最小值。")]
            public bool RequireAllMinimums { get; set; } = true;
        }
    }
}