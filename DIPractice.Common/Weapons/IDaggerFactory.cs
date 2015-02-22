using System;

namespace DIPractice.Common.Weapons
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
}