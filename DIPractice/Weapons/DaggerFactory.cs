using DIPractice.Common.Weapons;
using System;

namespace DIPractice.Weapons
{
    internal class DaggerFactory : IDaggerFactory
    {
        #region Methods

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public IDagger Create()
        {
            return new Dagger();
        }

        #endregion Methods
    }
}