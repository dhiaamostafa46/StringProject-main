using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringProject
{
    public partial class Sub : Form
    {

        public string temp_string;
        public Sub(int op)
        {
            InitializeComponent();

            switch (op)
            {
                case 1: 

                    for (int i = 0; i < Program.split.Length; i++)
            {
                text.AppendText(Program.split[i]+"\n");

            } break;

      //-----------------
                case 2:
                    for (int i = 0; i < Program.char_array.Length; i++)
                    {
                        text.AppendText(Program.char_array[i] + "\n");

                    }
                    break;


            }
        }





        private void Sub_Load(object sender, EventArgs e)
        {
                    

            
        }
    }
}
