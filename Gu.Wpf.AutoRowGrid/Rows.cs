﻿namespace Gu.Wpf.AutoRowGrid
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// A collection of <see cref="Row"/> or <see cref="Rows"/>
    /// This is only used to group things in xaml.
    /// </summary>
    public class Rows : Collection<IRow>, IRow
    {
        /// <summary><see cref="Name"/> is not used for anything but can perhaps be good for documentation.</summary>
        public string Name { get; set; }

        /// <inheritdoc/>
        public AutoIncrementation AutoIncrementation { get; set; } = AutoIncrementation.Inherit;

        /// <inheritdoc/>
        public void AutoIncrement(AutoIncrementation parentAutoIncrementation)
        {
            var autoIncrementation = this.AutoIncrementation.CoerceWith(parentAutoIncrementation);
            foreach (var row in this)
            {
                row.AutoIncrement(autoIncrementation);
            }
        }
    }
}