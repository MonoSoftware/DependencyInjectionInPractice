using System;

namespace DIPractice.Weapons
{
    public class Samurai
    {
        #region Fields

        private readonly Sword sword;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        public Samurai()
        {
            this.sword = new Sword();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Attack(string target)
        {
            this.sword.Hit(target);
        }

        #endregion Methods
    }
}