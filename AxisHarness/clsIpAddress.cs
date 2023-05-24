// Copyright 2016 Renishaw plc.
//
// The contents of this file are the confidential property of Renishaw plc.
// Reproduction or transmission, either in whole or in part, is prohibited
// without the prior written consent of the copyright owner.
//
// Description: 
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace AxisHarness
{

    class clsIPAddress
    {
        private const string IpAddressKey = "Software\\Renishaw\\Generic_Controller\\IpAddresses";
        private static RegistryKey IPKey;

        public static void SetIPValue(string Ipvalue)
        {

            try
            {
                IPKey = Registry.LocalMachine;
                IPKey = IPKey.CreateSubKey(IpAddressKey);
                IPKey.SetValue(Ipvalue, "");
                IPKey.SetValue("LastIP", Ipvalue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void GetAddresses(ref ComboBox IpList)
        {
            IpList.Items.Clear();
            IPKey = Registry.LocalMachine;
            IPKey = IPKey.OpenSubKey(IpAddressKey);
            string LastIP = "";
            foreach (string KeyArray in IPKey.GetValueNames())
            {
                if (KeyArray == "LastIP")
                {
                    LastIP = (String)IPKey.GetValue("LastIP");
                }
                else
                {
                    IpList.Items.Add(KeyArray);
                }
            }
            if (LastIP != "")
            {
                IpList.Text = LastIP;
            }
            else
            {
                IpList.Text = (String)IpList.Items[0];
            }
        }




    }
}
