using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon ClickEurekaMagiciteItemShardList.
/// </summary>
public sealed unsafe class ClickEurekaMagiciteItemShardList : ClickBase<ClickEurekaMagiciteItemShardList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickEurekaMagiciteItemShardList"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickEurekaMagiciteItemShardList(IntPtr addon = default)
        : base("EurekaMagiciteItemShardList", addon)
    {
    }

    public static implicit operator ClickEurekaMagiciteItemShardList(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickEurekaMagiciteItemShardList Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Switch to a different magicite category.
    /// </summary>
    /// <param name="cateId">magicite category index (0-6) in the UI.</param>
    public void SwitchCategory(int cateId)
        => this.FireCallback(12, cateId);

    /// <summary>
    /// Put a magicite item into the selected array.
    /// </summary>
    /// <param name="index">magicite item index (1-28).</param>
    public void SelectItem(int index)
        => this.FireCallback(14, index);
}
