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

                Form13 novaform13 = new Form13(_banco, quizID);
                novaform13.contador = contador;
                novaform13.ShowDialog();
                contador = novaform13.contador;

                Form14 novaform14 = new Form14(_banco, quizID);
                novaform14.contador = contador;
                novaform14.ShowDialog();
                contador = novaform14.contador;

                Form15 novaform15 = new Form15(_banco, quizID);
                novaform15.contador = contador;
                novaform15.ShowDialog();
                contador = novaform15.contador;

                Form16 novaform16 = new Form16(_banco, quizID);
                novaform16.contador = contador;
                novaform16.ShowDialog();
                contador = novaform16.contador;

                Form17 novaform17 = new Form17(_banco, quizID);
                novaform17.contador = contador;
                novaform17.ShowDialog();
                contador = novaform17.contador;

                Form18 novaform18 = new Form18(_banco, quizID);
                novaform18.contador = contador;
                novaform18.ShowDialog();
                contador = novaform18.contador;

                Form19 novaform19 = new Form19(_banco, quizID);
                novaform19.contador = contador;
                novaform19.ShowDialog();
                contador = novaform19.contador;

                Form20 novaform20 = new Form20(_banco, quizID);
                novaform20.contador = contador;
                novaform20.ShowDialog();
                contador = novaform20.contador;

                Form21 novaform21 = new Form21(_banco, quizID);
                novaform21.contador = contador;
                novaform21.ShowDialog();
                contador = novaform21.contador;

                Form22 novaform22 = new Form22(_banco, quizID);
                novaform22.contador = contador;
                novaform22.ShowDialog();
                contador = novaform22.contador;

            Form24 novaform24 = new Form24(_banco, quizID);
            novaform24.contador = contador;
            novaform24.ShowDialog();
            contador = novaform24.contador;

            Form25 novaform25 = new Form25(_banco, quizID);
            novaform25.contador = contador;
            novaform25.ShowDialog();
            contador = novaform25.contador;

            Form26 novaform26 = new Form26(_banco, quizID);
            novaform26.contador = contador;
            novaform26.ShowDialog();
            contador = novaform26.contador;

            Form27 novaform27 = new Form27(_banco, quizID);
            novaform27.contador = contador;
            novaform27.ShowDialog();
            contador = novaform27.contador;

            Form28 novaform28 = new Form28(_banco, quizID);
            novaform28.contador = contador;
            novaform28.ShowDialog();
            contador = novaform28.contador;

            Form7 novaform7 = new Form7(_banco, quizID);
                novaform7.contador = contador;
                novaform7.ShowDialog();

                Close();



           
        }

    }
}


