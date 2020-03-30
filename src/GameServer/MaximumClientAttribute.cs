﻿// <copyright file="MaximumClientAttribute.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer
{
    using MUnique.OpenMU.GameLogic.Views;
    using MUnique.OpenMU.Network.PlugIns;

    /// <summary>
    /// Attribute to mark an implemented <see cref="IViewPlugIn"/> with a specific (inclusive) maximum client version.
    /// </summary>
    public class MaximumClientAttribute : ClientAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumClientAttribute"/> class.
        /// </summary>
        /// <param name="season">The minimum season of compatible clients.</param>
        /// <param name="episode">The minimum episode of compatible clients.</param>
        /// <param name="language">The language of compatible clients.</param>
        public MaximumClientAttribute(byte season, byte episode, ClientLanguage language)
            : base(season, episode, language)
        {
        }
    }
}