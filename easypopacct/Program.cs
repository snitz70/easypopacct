﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easypopacct
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                CalculateAcct(args[0]);
            }
        }

        static void CalculateAcct(string args)
        {
            int acct = Convert.ToInt16(args);
            acct -= 2000;
            string acct_text = Convert.ToString(acct);
            Clipboard.SetText(acct_text);
        }
    }
}
