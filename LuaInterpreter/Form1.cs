using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuaInterface;

namespace LuaInterpreter
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic lua = new DynamicLua.DynamicLua();
                lua(txt1.Text);
               
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}
