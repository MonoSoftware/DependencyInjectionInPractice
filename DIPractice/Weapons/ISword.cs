using System;

namespace DIPractice.Weapons
{
    public interface ISword : IWeapon
    {
        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        void Hit(string target);

        #endregion Methods
    }
}