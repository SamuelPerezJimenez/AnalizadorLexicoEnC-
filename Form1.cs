using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico1_17_0167
{
    public partial class MainForm : Form
    {
        Lexico Analiza_Lexico = new Lexico();
        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine((3));
        }

        private void AnalizarBtn_Click(object sender, EventArgs e)
        {
            Analiza_Lexico.Inicia();
            Analiza_Lexico.Analiza(textBox_codigo.Text);
            resultadoDgv.Rows.Clear();
            if (Analiza_Lexico.NoTokens > 0)
                resultadoDgv.Rows.Add(Analiza_Lexico.NoTokens);
            for (int i = 0; i < Analiza_Lexico.NoTokens; i++)
            {
                resultadoDgv.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i];
                resultadoDgv.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i];
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            //Limpiar el Datagrid
            resultadoDgv.Rows.Clear();
            //Limpiar el TextBoxt
            textBox_codigo.Text = "";
            textBox_codigo.Focus();
        }
    }
}
