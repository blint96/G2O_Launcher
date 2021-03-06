﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="ILauncherConfig.cs" company="Gothic Online Project">
//  Copyright (C) <2016>  <Julian Vogel>
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  -
//  This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
// -
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http:www.gnu.org/licenses/>.
//  </copyright>
//  -------------------------------------------------------------------------------
namespace G2O_Launcher.Config
{
    #region

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The LauncherConfig interface.
    /// </summary>
    public interface ILauncherConfig
    {
        /// <summary>
        ///     Gets the favorite servers list.
        /// </summary>
        List<string> FavoriteServers { get; }

        /// <summary>
        ///     Gets or sets the selected language.
        /// </summary>
        string SelectedLanguage { get; set; }

        /// <summary>
        ///     Gets or sets the selected tab index.
        /// </summary>
        int SelectedTabIndex { get; set; }
    }
}