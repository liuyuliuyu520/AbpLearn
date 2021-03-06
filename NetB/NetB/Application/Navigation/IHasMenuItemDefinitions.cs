﻿using System.Collections.Generic;

namespace NetB.Application.Navigation
{
    /// <summary>
    /// Declares common interface for classes those have menu items.
    /// </summary>
    public interface IHasMenuItemDefinitions
    {
        /// <summary>
        /// List of menu items.
        /// </summary>
        IList<MenuItemDefinition> Items { get; }
    }
}