﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoL.Extensions
{
    public static class StringExtensions
    {
        public static byte[] ParseMacAddress(this string mac)
        {
            var macString = mac.Replace(":", "-");
            return System.Net.NetworkInformation.PhysicalAddress.Parse(macString).GetAddressBytes();
        }

        public static bool TryParseMacAddress(this string mac, out byte[] bytes)
        {
            bytes = null;
            try
            {
                bytes = ParseMacAddress(mac);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
