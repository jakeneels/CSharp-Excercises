﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, 
         return an array with the elements "rotated left" 
         so {1, 2, 3} 
         yields {2, 3, 1}.
         rotateLeft3([1, 2, 3]) → [2, 3, 1]
         rotateLeft3([5, 11, 9]) → [11, 9, 5]
         rotateLeft3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] RotateLeft3(int[] nums)
        {
            int[] rotateLeft = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                {
                    rotateLeft[i - 1] = nums[i];

                }
                else
                {
                    rotateLeft[nums.Length - 1] = nums[0];

                }
            }
            return rotateLeft;
        }

    }
}
