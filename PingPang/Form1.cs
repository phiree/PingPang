using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingPang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtResult.ResetText();
            List<string> list=new List<string>();
            list.AddRange(rtBoy.Lines);

            rtResult.AppendText("男子组"+Environment.NewLine);
            RandomPair rp = new RandomPair(list, 4);
            DisplayResult(rp.DoPair());
            rtResult.AppendText("女子组" + Environment.NewLine);
            List<string> list2 = new List<string>();
            list2.AddRange(rtGirl.Lines);
            RandomPair rp2 = new RandomPair(list2, 3);
            DisplayResult(rp2.DoPair());

           
        }
        private void DisplayResult(Dictionary<int,List<string>> list)
        {
            foreach (int key in list.Keys)
            {
                string s = "小组" + (key + 1) + Environment.NewLine;
                rtResult.AppendText(s);
                foreach (string s1 in list[key])
                {
                    rtResult.AppendText("     " + s1 + Environment.NewLine);
                }
            }
        }

    }
}
