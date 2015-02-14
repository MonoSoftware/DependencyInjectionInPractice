using System;

namespace DIPractice.Weapons
{
    public class Sword
    {
        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }

        #endregion Methods
    }
}