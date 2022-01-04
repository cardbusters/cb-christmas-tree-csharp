using System;
using System.Collections.Generic;

namespace christmas_tree_kata
{
    internal class Christmastree
    {
        internal static List<object> Draw(int v)
        {
            var list = new List<object>();

            for (int i = 0; i < v; i++)
            {
                // find spaces
                // find x'es
                //concat and add into list
                string temp = "";
                for (int k = 0; k < 7 - i; k++)
                {
                    temp += " ";
                }
                for (int z = 0; z <= i; z++)
                {
                    temp += "X";
                }

                list.Add(temp);
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