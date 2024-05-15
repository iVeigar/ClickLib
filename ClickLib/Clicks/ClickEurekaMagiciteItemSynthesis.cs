using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon ClickEurekaMagiciteItemSynthesis.
/// </summary>
public sealed unsafe class ClickEurekaMagiciteItemSynthesis : ClickBase<ClickEurekaMagiciteItemSynthesis>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickEurekaMagiciteItemSynthesis"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickEurekaMagiciteItemSynthesis(IntPtr addon = default)
        : base("EurekaMagiciteItemSynthesis", addon)
    {
    }

    public static implicit operator ClickEurekaMagiciteItemSynthesis(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickEurekaMagiciteItemSynthesis Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Retrieve the magicite shard item specified by index from arrays.
    /// </summary>
    /// <param name="index">Magicite item index, 0-2 in astral array, 3-5 in umbral array.</param>
    public void Retrieve(int index)
        => this.FireCallback(18, index);

    /// <summary>
    /// Put the magicite shard item in array.
    /// </summary>
    /// <param name="array">Array id, umbral array (1) or astral array (0).</param>
    /// <param name="item">Magicite item id (1-28).</param>
    public void Put(int array, int item)
        => this.FireCallback(22, (array << 16) + item);

    /// <summary>
    /// Transfer the magicite shard item between arrays.
    /// </summary>
    /// <param name="index">Magicite item index, 0-2 in astral array, 3-5 in umbral array.</param>
    public void Transfer(int index)
        => this.FireCallback(23, (index < 3 ? 65536 : 0) + index);

    /// <summary>
    /// Click the synthesis button.
    /// </summary>
    public void Synthesis()
        => this.FireCallback(24);

    /// <summary>
    /// Click the discard button.
    /// </summary>
    public void Discard()
        => this.FireCallback(26);

    /// <summary>
    /// Click the replace button.
    /// </summary>
    public void Replace()
        => this.FireCallback(27);

    /// <summary>
    /// Click the confirm button.
    /// </summary>
    public void Confirm()
        => this.FireCallback(28);

    /// <summary>
    /// Select the specified array.
    /// </summary>
    /// <param name="array">Array id, umbral array (1) or astral array (0).</param>
    public void SelectArray(int array)
        => this.FireCallback(29, array);
}
