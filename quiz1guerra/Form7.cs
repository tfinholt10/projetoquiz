using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quiz1guerra
{
    public partial class Form7 : Form
    {
        public int contador;
        private THO _banco = new THO();
        private int _quizID;
        public Form7(THO banco, int quizID)
        {
            InitializeComponent();
            contador = 0;
            _banco = banco;
            _quizID = quizID;
        }

       
        private void Form7_Load(object sender, EventArgs e)
        {
            int respfinal;
            respfinal = contador;

            try
            {
                string sql = "UPDATE quiz SET respfinal = @respfinal";
                sql += " where id = @_quizID";

                List<MySqlParameter> valores = new List<MySqlParameter>();
                valores.Add(new MySqlParameter("@respfinal", respfinal));
                valores.Add(new MySqlParameter("@_quizID", _quizID));
                _banco.Atualizar(sql, valores);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (contador >= 4)
            {
                label1.Text = "Parabéns você acertou " + contador.ToString() + " perguntas!";
            }

            if (contador < 3)
            {
                label1.Text = "Estude mais, você acertou somente " + contador.ToString() + " perguntas!";

            }
            if(contador == 1)
            {
                label1.Text = "Estude mais, você acertou somente " + contador.ToString() + " pergunta!";

            }
            
            if (contador == 0)
            {
                label1.Text = "Realmente você não tem jeito, acertou nenhuma questão!";

               
                label1.Left = (Width - label1.Width)/ 2;
                label1.Top = (Height - label1.Height)/ 2;

                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
