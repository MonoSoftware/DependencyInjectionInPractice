using DIPractice.Warriors;
using DIPractice.Weapons;
using Ninject;
using System;
using System.Threading;

namespace DIPractice
{
    public class Program
    {
        #region Methods

        private static void Attack(IKernel kernel)
        {
            Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
            var warrior1 = kernel.Get<IWarrior>();
            warrior1.Attack("the evildoers");

            Console.WriteLine("Who do you want to kill today?");
            Console.Out.Flush();
            var name = Console.ReadLine();

            var warrior2 = kernel.Get<IWarrior>();
            warrior2.Attack(name);
        }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            //NOTE: Composition Root
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDagger>().To<Dagger>();
            kernel.Bind<IDaggerFactory>().To<DaggerFactory>();

            kernel.Bind<IWeapon>().To<Shuriken>();
            kernel.Bind<IWeapon>().To<Sword>();

            kernel.Bind<IWeaponFactory>().To<WeaponFactory>();

            kernel.Bind<IWarrior>().To<Samurai>().InThreadScope();

            StartNewThread(() =>
                {
                    Attack(kernel);
                }).Join();

            Console.WriteLine();
            Console.WriteLine("We are bloodthirsty today ...");
            Console.WriteLine();

            StartNewThread(() =>
            {
                Attack(kernel);
            });
        }

        private static Thread StartNewThread(Action a)
        {
            Thread t = new Thread(new ThreadStart(a));
            t.Start();
            return t;
        }

        #endregion Methods
    }
}