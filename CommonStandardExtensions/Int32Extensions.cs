namespace CommonStandardExtensions
{
    using System;

    public static class Int32Extensions
    {
        /// <summary>
        /// Ensures the given number is greater than or equal to the minimum and greater than or equal to the
        /// maximum. If it's in between then the value is unchanged.
        /// </summary>
        public static int Clamp(this int toClamp, int min, int max)
        {
            if(max < min)
                throw new ArgumentException("min cannot be greater than max");
                
            if (toClamp < min)
                return min;
            
            if (toClamp > max)
                return max;

            return toClamp;
        }
    }
}