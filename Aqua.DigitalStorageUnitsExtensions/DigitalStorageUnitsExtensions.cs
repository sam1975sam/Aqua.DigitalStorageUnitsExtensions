﻿namespace Aqua.DigitalStorageUnitsExtensions
{
    public static class DigitalStorageUnitsExtensions
    {
        private const decimal KiloByte = 1024;
        private const decimal Megabyte = 1048576;

        /// <summary>
        /// Converts Byte to KiloByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToKiloByte(this decimal input)
        {
            return input / KiloByte;
        }

        /// <summary>
        /// Converts KiloByte to Byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal KiloByteToByte(this decimal input)
        {
            return input * KiloByte;
        }

        /// <summary>
        /// Converts Byte to MegaByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToMegaByte(this decimal input)
        {
            return input / Megabyte;
        }

    }
}
