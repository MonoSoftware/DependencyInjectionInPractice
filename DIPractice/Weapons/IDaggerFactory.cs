using System;

namespace DIPractice.Weapons
{
    public interface IDaggerFactory
    {
        #region Methods

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        IDagger Create();

        #endregion Methods
    }

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