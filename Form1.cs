using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Memory;


namespace Assault_Cube_Memory
{
    public partial class Form1 : Form
    {
        Mem Memoria = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           int PID =  Memoria.GetProcIdFromName("ac_client.exe");
            if(PID > 0) 
            {
                Memoria.OpenProcess(PID);
            }
        }

        private void Injectar_Click(object sender, EventArgs e)
        {
            while (true) 
            {
                Memoria.WriteMemory("ac_client.exe + 0x00183828,0x8,0x790,0x30,0x30,0x64,0x30,0x220", "int", Num_Injectar.Text);
                Thread.Sleep(2000);
            }
        }
    }
}
