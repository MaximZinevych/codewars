﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_project
{
    class Task_03
    {
        /*
        Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. 
        However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
        Your task is to write a function maskify, which changes all but the last four characters into '#'.

        Examples
        Kata.Maskify('4556364607935616'); // should return "############5616"
        Kata.Maskify('64607935616');      // should return "#######5616"
        Kata.Maskify('1');                // should return "1"
        Kata.Maskify('');                 // should return ""

        // "What was the name of your first pet?"
        Kata.Maskify('Skippy');                                   // should return "##ippy"
        Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
         */
        public static string Maskify(string cc)
        {
            var lenght = cc.Length;
            if (lenght <= 4)
                return cc;

            return cc.Remove(0, lenght - 4).PadLeft(lenght, '#');
        }
    }
}
