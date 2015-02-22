using System;

namespace DIPractice.Common.Warriors
{
    public interface IWarrior
    {
        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        void Attack(string target);

        #endregion Methods
    }
}