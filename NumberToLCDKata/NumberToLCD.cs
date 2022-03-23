﻿using System;

namespace NumberToLCDKata
{
    internal class NumberToLCD
    {
        internal object GetDigital(int v)
        {
            switch (v)
            {
                case 0:
                    return @" _ 
| |
|_|";
                case 1:
                    return @"   
 | 
 | ";
                case 2:
                    return @" _ 
 _|
|_";
                case 3:
                    return @" _ 
 _|
 _|";
                case 4:
                    return @"   
|_|
  |";
                case 5:
                    return @" _ 
|_
 _|";
                case 6:
                    return 6;
                case 7:
                    return 7;
                case 8:
                    return 8;
                case 9:
                    return 9;
            }
            return "";
        }
    }
}