﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular_2
    {
        static void Main(string[] args)
        { 
            //*****
            //****
            //***
            //**
            //*
           
              
            for (int i=5;i>=1;i--)
            { 
                for (int j=i;j>=1;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
      
        }
    }
}
