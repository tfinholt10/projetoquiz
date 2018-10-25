﻿using System;
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
    public partial class Form6 : Form
    {
        public int contador;
        private THO _banco = new THO();
        private int _quizID;
        public Form6(THO banco, int quizID)
        {
            InitializeComponent();
            contador = 0;
            _banco = banco;
            _quizID = quizID;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            int resp5;
            if (radioButton2.Checked == true)
            {
                contador = contador + 1;
                resp5 = 1;

                try
                {
                    string sql = "UPDATE quiz SET resp5 = @resp5";
                    sql += " where id = @_quizID";

                    List<MySqlParameter> valores = new List<MySqlParameter>();
                    valores.Add(new MySqlParameter("@resp5", resp5));
                    valores.Add(new MySqlParameter("@_quizID", _quizID));
                    _banco.Atualizar(sql, valores);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (radioButton2.Checked == false)
            {
                contador = contador + 0;
                resp5 = 0;

                try
                {
                    string sql = "UPDATE quiz SET resp5 = @resp5 ";
                    sql += " where id = @_quizID";

                    List<MySqlParameter> valores = new List<MySqlParameter>();
                    valores.Add(new MySqlParameter("@resp5", resp5));
                    valores.Add(new MySqlParameter("@_quizID", _quizID));
                    _banco.Atualizar(sql, valores);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            Close();
        }
    }
}
