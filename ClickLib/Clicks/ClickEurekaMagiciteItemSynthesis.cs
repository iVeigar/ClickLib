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
    /// Select the specified array.
    /// </summary>
    /// <param name="id">Array id, umbral array (1) or astral array (0).</param>
    public void SelectArray(int id)
        => this.FireCallback(29, id);

    /// <summary>
    /// Click the synthesis button.
    /// </summary>
    public void Synthesis()
        => this.FireCallback(24);
}
