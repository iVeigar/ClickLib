using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Gathering.
/// </summary>
public sealed class ClickGathering : ClickBase<ClickGathering, AddonGathering>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickGathering"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickGathering(IntPtr addon = default)
        : base("Gathering", addon)
    {
    }

    public static implicit operator ClickGathering(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickGathering Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the gathering list.
    /// </summary>
    /// <param name="index">index of item in list.</param>
    public void GatherItem(uint index) => this.ClickAddonStage(index, Enums.EventType.CHANGE);

#pragma warning disable SA1134, SA1516, SA1600
    [ClickName("gathering_1")] public void GatherItem1() => this.GatherItem(0);
    [ClickName("gathering_2")] public void GatherItem2() => this.GatherItem(1);
    [ClickName("gathering_3")] public void GatherItem3() => this.GatherItem(2);
    [ClickName("gathering_4")] public void GatherItem4() => this.GatherItem(3);
    [ClickName("gathering_5")] public void GatherItem5() => this.GatherItem(4);
    [ClickName("gathering_6")] public void GatherItem6() => this.GatherItem(5);
    [ClickName("gathering_7")] public void GatherItem7() => this.GatherItem(6);
    [ClickName("gathering_8")] public void GatherItem8() => this.GatherItem(7);
#pragma warning restore SA1134, SA1516, SA1600
}
