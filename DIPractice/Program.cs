using DIPractice.Weapons;
using System;

namespace DIPractice
{
    public class Program
    {
        #region Methods

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            var warrior = new Samurai();
            warrior.Attack("the evildoers");
        }

        #endregion Methods
    }
}