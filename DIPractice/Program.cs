﻿/*
 * Dependency Injection in Practice
 * Copyright 2015 Kristijan Horvat
 *
 * Examples taken from Ninject  Wiki
 * https://github.com/ninject/Ninject/wiki/
 *
 * */

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
            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
        }

        #endregion Methods
    }
}