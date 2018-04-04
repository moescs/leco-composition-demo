﻿namespace Composition.Share
{
    using System;

    /// <summary>
    /// Details unimportant
    /// </summary>
    public class Base
    {
        static readonly double SquareRootOfTwoPi = Math.Sqrt(2*Math.PI);

        /// <summary>
        ///
        /// </summary>
        /// <param name="y1">first point</param>
        /// <param name="y2">middle point</param>
        /// <param name="y3">last point</param>
        /// <returns></returns>
        public GaussianParameters Fit(
            double y1,
            double y2,
            double y3)
        {
            var r1 = Math.Log(y2 / y1);
            var r2 = Math.Log(y3 / y2);
            var parameters = FitUsingRatios(r1: r1, r2: r2, y2: y2);
            return parameters;
        }

        static GaussianParameters FitUsingRatios(
            double r1,
            double r2,
            double y2)
        {
            var mu = (r1 + r2) / (2d * (r1 - r2));
            var a = (r1 - r2) / 2d;
            var sigma = 1 / Math.Sqrt(2d * a);
            var h = y2 * Math.Exp(a * mu * mu);
            var area = h * sigma * SquareRootOfTwoPi;
            return new GaussianParameters
            {
                Mean = mu,
                StandardDeviation = sigma,
                Area = area
            };
        }
    }
}