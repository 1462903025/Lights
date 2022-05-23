// -----------------------------------------------------------------------
// <copyright file="Presets.cs" company="Beryl">
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
    /// Configs containing everything preset-related.
    /// </summary>
    public class Presets
    {
        /// <summary>
        /// Gets or sets a value indicating whether presets will be able to be executed.
        /// </summary>
        [Description("�Ƿ�����Ԥ��ϵͳ��")]
        public bool AreEnabled { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether presets will be ran in random order.
        /// </summary>
        [Description("�Ƿ������˳������Ԥ�衣")]
        public bool RandomOrder { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether running presets through a command requires a specific permission for it.
        /// </summary>
        [Description("ͨ����������Ԥ���Ƿ���Ҫ�ض�Ȩ��")]
        public bool SpecificPermissionsRequired { get; set; } = false;

        /// <summary>
        /// Gets or sets how many times this plugin will loop through the preset order.
        /// </summary>
        [Description("����������Ԥ��˳����ѭ�����ٴΡ�")]
        public uint LoopCount { get; set; } = 5;

        /// <summary>
        /// Gets or sets the minimum amount of time that will pass until next preset is ran.
        /// </summary>
        [Description("������һ��Ԥ��֮ǰ�����ʱ�䡣")]
        public float TimeBetweenMin { get; set; } = 55;

        /// <summary>
        /// Gets or sets the maximum amount of time that might pass until next preset is ran.
        /// </summary>
        [Description("������һ��Ԥ��֮ǰ���ܾ������ʱ�䡣")]
        public float TimeBetweenMax { get; set; } = 82;

        /// <summary>
        /// Gets or sets the minimum amount of time until presets begin getting looped through.
        /// </summary>
        [Description("�����ʼִ��Ԥ��֮ǰ���ӳ١�")]
        public float InitialDelay { get; set; } = 32;

        /// <summary>
        /// Gets or sets a list of presets, one of which will be selected as the first preset ran, taking from <see cref="PerZone"/> and <see cref="PerRoom"/>.
        /// </summary>
        [Description("�����ѡ��˴��г�������һ��Ԥ����Ϊ��һ��Ԥ������ (�� \"!\" ��ͷ���н������ԣ��������ʹ�ô�ϵͳ����ʹ�ô��У�")]
        public string[] InitialPreset { get; set; } = { "!ignore", "!ignored2" };

        /// <summary>
        /// Gets or sets the order on which presets will be ran, taking from <see cref="PerZone"/> and <see cref="PerRoom"/>.
        /// </summary>
        [Description("����Ԥ���˳��")]
        public string[] Order { get; set; } = { "myZonePreset2", "myRoomPreset1", "myRoomPreset2", };

        /// <summary>
        /// Gets or sets a dictionary containing all <see cref="ZoneType"/>-exclusive presets.
        /// </summary>
        [Description("����Ԥ�裬�⽫ֻ�����������͡� (���������б� https://github.com/Exiled-Team/EXILED/blob/master/Exiled.API/Enums/ZoneType.cs )")]
        public Dictionary<string, Preset<ZoneType>[]> PerZone { get; set; } = new Dictionary<string, Preset<ZoneType>[]>()
        {
            {
                "myZonePreset1", new Preset<ZoneType>[]
                {
                    new Preset<ZoneType>(ZoneType.Entrance, ModifierType.Blackout, 45, 0),
                    new Preset<ZoneType>(ZoneType.Surface, ModifierType.Color, -1, 255, 100, 255),
                    new Preset<ZoneType>(ZoneType.LightContainment, ModifierType.Intensity, -1, 0.5f),
                }
            },
            {
                "myZonePreset2", new Preset<ZoneType>[]
                {
                    new Preset<ZoneType>(ZoneType.HeavyContainment, ModifierType.Blackout, 15, 0),
                    new Preset<ZoneType>(ZoneType.Surface, ModifierType.Color, -1, 255, 100, 255),
                    new Preset<ZoneType>(ZoneType.LightContainment, ModifierType.Intensity, -1, 0.5f),
                }
            },
        };

        /// <summary>
        /// Gets or sets a dictionary containing all <see cref="RoomType"/>-exclusive presets.
        /// </summary>
        [Description("����Ԥ�裬�⽫ֻ���ܷ������͡� (���������б� https://github.com/Exiled-Team/EXILED/blob/master/Exiled.API/Enums/RoomType.cs )")]
        public Dictionary<string, Preset<RoomType>[]> PerRoom { get; set; } = new Dictionary<string, Preset<RoomType>[]>()
        {
            {
                "myRoomPreset1", new Preset<RoomType>[]
                {
                    new Preset<RoomType>(RoomType.EzCafeteria, ModifierType.Blackout, 45, 0),
                    new Preset<RoomType>(RoomType.Hcz049, ModifierType.Color, -1, 255, 100, 255),
                    new Preset<RoomType>(RoomType.HczEzCheckpoint, ModifierType.Intensity, -1, 0.5f),
                }
            },
            {
                "myRoomPreset2", new Preset<RoomType>[]
                {
                    new Preset<RoomType>(RoomType.Hcz096, ModifierType.Blackout, 45, 0),
                    new Preset<RoomType>(RoomType.HczCurve, ModifierType.Color, -1, 255, 100, 255),
                    new Preset<RoomType>(RoomType.HczEzCheckpoint, ModifierType.Lockdown, 7, 0),
                }
            },
        };
    }
}