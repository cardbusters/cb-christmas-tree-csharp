using System;
using System.Collections.Generic;

namespace christmas_tree_kata
{
    internal class Christmastree
    {
        internal static List<object> Draw(int v)
        {
            if (v < 5)
            {
                v = 5;
            }

            var list = new List<object>();

            var numberOfX = 1;
            var numberOfSpace = 7;
            for (int i = 0; i < v; i++)
            {
                string temp = "";
                for (int k = 0; k < numberOfSpace; k++)
                {
                    temp += " ";
                }
                for (int z = 0; z < numberOfX; z++)
                {
                    temp += "X";
                }

                list.Add(temp);

                numberOfX += 2;
                numberOfSpace -= 1;
            }
            list.Add("       X");

            // var list = new List<object>(){
            //     "       X",
            //     "      XXX",
            //     "     XXXXX",
            //     "    XXXXXXX",
            //     "   XXXXXXXXX",
            //     "       X"};

            return list;
        }
    }
}