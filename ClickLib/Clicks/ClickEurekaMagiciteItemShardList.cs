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
    /// <param name="cate">magicite category index (0-6).</param>
    public void SwitchCategory(uint cate)
        => this.FireCallback(12, cate);

    /// <summary>
    /// Put the magicite shard into the highlighted array.
    /// </summary>
    /// <param name="item">magicite item index (1-28).</param>
    public void ClickItem(int item)
        => this.FireCallback(14, item);

    /// <summary>
    /// Put the magicite shard in specified array.
    /// </summary>
    /// <param name="array">Array id, umbral array (1) or astral array (0).</param>
    /// <param name="item">magicite item index (1-28).</param>
    public void Put(int array, int item)
        => this.FireCallback(22, (uint)(array << 16) + item);
}
