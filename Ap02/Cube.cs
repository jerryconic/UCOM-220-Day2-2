﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap02
{
    internal class Cube
    {
        
        private double _length, _width, _height;
        
        /// <summary>
        /// 立方體的建構函式        
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        public Cube(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        /// <summary>
        /// 計算立方體的體積
        /// </summary>
        /// <returns>長X寬X高</returns>
        public double Volume()
        {
            return _length * _width * _height;
        }
        /// <summary>
        /// 計算立方體的表面積
        /// </summary>
        /// <returns>表面積</returns>
        public double Area()
        {
            return 2 * (_length * _width + _width * _height + _height * _length);
        }
    }
}
