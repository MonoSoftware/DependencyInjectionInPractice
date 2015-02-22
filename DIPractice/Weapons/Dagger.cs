using DIPractice.Common.Weapons;
using System;

namespace DIPractice.Weapons
{
    public class Dagger : IDagger
    {
        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns></returns>
        public void Hit(string target)
        {
            Console.WriteLine("Stab " + target + " to death");
        }

        #endregion Methods
    }
}