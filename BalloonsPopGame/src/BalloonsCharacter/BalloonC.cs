﻿// <copyright file="BalloonC.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    /// <summary>
    /// Class generates concrete balloon.
    /// </summary>
    public class BalloonC : Balloon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalloonC"></see> class.
        /// </summary>
        public BalloonC()
        {
            this.Symbol = 'C';
            this.Color = "Red";
        }
    }
}
