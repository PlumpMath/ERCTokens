﻿using AntShares.SmartContract.Framework;
using AntShares.SmartContract.Framework.Services.AntShares;
using System;
using System.Numerics;

namespace ERC20Demo
{
    public class Contract1 : FunctionCode
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "ERC20Demo");
        }
    }
}