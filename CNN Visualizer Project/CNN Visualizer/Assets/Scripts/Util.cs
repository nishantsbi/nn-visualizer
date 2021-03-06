﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Util
{
    /// <summary>
    /// Returns a multi dimensional index  from a single dimensional one based on the shape of the multidimensional array.
    /// </summary>
    /// <param name="shape"></param>
    /// <param name="singleDimInd"></param>
    /// <returns></returns>
    public static int[] GetMultiDimIndices(int[] shape, int singleDimInd)
    {
        int rank = shape.Length;
        int[] index = new int[shape.Length];

        int div = singleDimInd;
        for (int j = 0; j < rank; j++)
        {
            int oldDiv = div;
            div = div / shape[j];
            index[j] = oldDiv - div * shape[j];
        }
        return index;
    }

    public static int[] GetSampleMultiDimIndices(int[] shape, int singleDimInd, int sample)
    {
        int rank = shape.Length;
        int[] index = new int[shape.Length];

        int div = singleDimInd;
        for (int j = 0; j < rank; j++)
        {
            int dim = shape[j];
            if (j == 0)
                dim = 1;

            int oldDiv = div;
            div = div / dim;
            index[j] = oldDiv - div * dim;

            if (j == 0)
                index[j] = sample;
        }
        return index;
    }
}
