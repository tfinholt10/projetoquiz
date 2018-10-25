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
    
    public partial class Form1 : Form
    {
        private THO _banco = new THO();
        int contador;
        public int quizID;


        public Form1()
        {
            InitializeComponent();
            _banco.DBName = "guerra_mundial";
            _banco.Conectar();
            contador = 0;
        }

        

       
            
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO quiz ";
                sql += "(id, nome) VALUES (NULL,'";
                sql += textBox1.Text + "');";
                sql += "SELECT LAST_INSERT_ID() as id;";

                DataSet resultado = _banco.Buscar(sql);
                
                


                if (resultado.Tables["tbl_resultado"].Rows.Count == 1)
                {
                    quizID = Convert.ToInt32(resultado.Tables["tbl_resultado"].Rows[0]["id"].ToString());
                    MessageBox.Show(quizID.ToString());

                }
                else
                {
                    MessageBox.Show("Erro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            this.Visible = false;

                
                Form2 novaform = new Form2(_banco, quizID);
                novaform.contador = contador;
                novaform.ShowDialog();
                contador = novaform.contador;

                Form3 novaform3 = new Form3(_banco, quizID);
                novaform3.contador = contador;
                novaform3.ShowDialog();
                contador = novaform3.contador;

                Form4 novaforma4 = new Form4(_banco, quizID);
                novaforma4.contador = contador;
                novaforma4.ShowDialog();
                contador = novaforma4.contador;

                Form5 novaform5 = new Form5(_banco, quizID);
                novaform5.contador = contador;
                novaform5.ShowDialog();
                contador = novaform5.contador;

                Form6 novaform6 = new Form6(_banco, quizID);
                novaform6.contador = contador;
                novaform6.ShowDialog();
                contador = novaform6.contador;

                Form7 novaform7 = new Form7(_banco, quizID);
                novaform7.contador = contador;
                novaform7.ShowDialog();

                Form8 novaform8 = new Form8();
                novaform8.ShowDialog();

                Form9 novaform9 = new Form9();
                novaform9.ShowDialog();

                Form10 novaform10 = new Form10();
                novaform10.ShowDialog();

                Form11 novaform11 = new Form11();
                novaform11.ShowDialog();

                Form12 novaform12 = new Form12();
                novaform12.ShowDialog();
                Close();



           
        }

    }
}


