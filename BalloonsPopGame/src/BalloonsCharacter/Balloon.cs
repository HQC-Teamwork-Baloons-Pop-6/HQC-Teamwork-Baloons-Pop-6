// <copyright file="Balloon.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    /// <summary>
    /// Abstract class for balloons structure.
    /// </summary>
    public abstract class Balloon
    {
        /// <summary>
        /// Gets or sets Symbol property.
        /// </summary>
        /// <value>Gets or sets the value of Symbol.</value>
        public char Symbol { get; protected set; }

        /// <summary>
        /// Gets or sets Color property.
        /// </summary>
        /// <value>Gets or sets the Color value.</value>
        public string Color { get; protected set; }
    }
}
