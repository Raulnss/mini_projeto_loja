using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_do_Andre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Timer timer1;
        private void remove_Click(object sender, EventArgs e)
        {
            string cd = cd_box1.Text;
            string name = nm_box1.Text;
            cd = cd.Trim();
            name = name.Trim();
            cd = cd.ToLower();
            name = name.ToLower();
            /*cd = cd.Normalize(NormalizationForm.FormD).Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a")
                    .Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e")
                    .Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i")
                    .Replace("ó", "o").Replace("ò", "o").Replace("ô", "o").Replace("õ", "o")
                    .Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u")
                    .Replace("ç", "c").Replace(".", "").Replace(",", "").Replace("´", "")
                    .Replace("~", "").Replace("`", "").Replace("^", "").Replace("¸", "").Replace(";", "")
                    .Replace(":", "").Replace("º", "").Replace("₢", "").Replace("!", "").Replace("@", "")
                    .Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "")
                    .Replace("*", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("+", "")
                    .Replace("=", "").Replace("§", "").Replace("|", "").Replace("/", "").Replace("°", "")
                    .Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "").Replace("ª", "")
                    .Replace("º", "").Replace("'", "").Replace("''", "").Replace("<", "").Replace(">", "")
                    .Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "");
            name = name.Normalize(NormalizationForm.FormD).Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a")
                    .Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e")
                    .Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i")
                    .Replace("ó", "o").Replace("ò", "o").Replace("ô", "o").Replace("õ", "o")
                    .Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u")
                    .Replace("ç", "c").Replace(".", "").Replace(",", "").Replace("´", "")
                    .Replace("~", "").Replace("`", "").Replace("^", "").Replace("¸", "").Replace(";", "")
                    .Replace(":", "").Replace("º", "").Replace("₢", "").Replace("!", "").Replace("@", "")
                    .Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "")
                    .Replace("*", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("+", "")
                    .Replace("=", "").Replace("§", "").Replace("|", "").Replace("/", "").Replace("°", "")
                    .Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "").Replace("ª", "")
                    .Replace("º", "").Replace("'", "").Replace("''", "").Replace("<", "").Replace(">", "")
                    .Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "");*/
            string valor_co = "";
            bool n1 = true;
            bool n2 = false;
            bool n3 = false;
            bool n4 = false;
            bool n5 = false;
            if (!string.IsNullOrWhiteSpace(cd) && !string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    using (var cn = new MySqlConnection(Conn.strConn))
                    {
                        cn.Open();
                        var veri = new MySqlCommand("SELECT * FROM produtos WHERE cd_produto = @cd AND nm_produto = @nome", cn);
                        veri.Parameters.AddWithValue("@cd", cd);
                        veri.Parameters.AddWithValue("@nome", name);

                        var reader = veri.ExecuteReader();

                        if (reader.Read())
                        {
                            n1 = true;
                        }
                        else
                        {
                            MessageBox.Show("Error: Produto não costa na base de dados");
                            n1 = false;
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                try
                {
                    using (var cn4 = new MySqlConnection(Conn.strConn))
                    {
                        cn4.Open();
                        var veri = new MySqlCommand("SELECT qt_produto FROM quantidade WHERE nm_produto = @nome", cn4);
                        veri.Parameters.AddWithValue("@nome", name);

                        var reader3 = veri.ExecuteReader();

                        if (reader3.Read())
                        {
                            var dado = reader3["qt_produto"].ToString();
                            int valor = int.Parse(dado);
                            if (valor > 0)
                            {
                               n3 = true;
                            }
                            else
                            {
                                MessageBox.Show("Alerta: Produto consta com a quantidade 0 na base de dados, ele não deveria existir.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Produto não costa na base de dados");
                            n3 = false;
                        }
                        cn4.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                if (n3 == true)
                {
                    try
                    {
                        using (var cn1 = new MySqlConnection(Conn.strConn))
                        {
                            cn1.Open();
                            var cadas = new MySqlCommand("DELETE FROM produtos WHERE cd_produto = @cd AND nm_produto = @nome", cn1);
                            cadas.Parameters.AddWithValue("@cd", cd);
                            cadas.Parameters.AddWithValue("@nome", name);
                            cadas.ExecuteNonQuery();
                            cn1.Close();
                            n4 = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    try
                    {
                        using (var cn2 = new MySqlConnection(Conn.strConn))
                        {
                            cn2.Open();
                            var veri2 = new MySqlCommand("SELECT * FROM quantidade WHERE nm_produto = @nome", cn2);
                            veri2.Parameters.AddWithValue("@nome", name);
                            var reader2 = veri2.ExecuteReader();

                            if (reader2.Read())
                            {
                                var dado = reader2["qt_produto"].ToString();
                                int valor = int.Parse(dado);
                                valor--;
                                valor_co = valor.ToString();
                                n2 = true;
                                if (valor <= 0)
                                {
                                    MessageBox.Show("Alerta: Esse produto acaba de consta como 0 na base de dados");
                                }
                            } 
                            else
                            {
                                n2 = false;
                            }
                            cn2.Close();
                        }
                        if (n2 == true)
                        {
                            try
                            {
                                using (var cn3 = new MySqlConnection(Conn.strConn))
                                {
                                    cn3.Open();
                                    var vl_up = valor_co;
                                    var up = new MySqlCommand("UPDATE quantidade SET qt_produto = @valor WHERE nm_produto = @nome", cn3);
                                    up.Parameters.AddWithValue("@valor", vl_up);
                                    up.Parameters.AddWithValue("@nome", name);
                                    up.ExecuteNonQuery();
                                    cn3.Close();
                                    n5 = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error: Quantidade do produto não encontrada");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                if (n1==true && n2 == true && n3 == true && n4 == true && n5 == true)
                {
                    //timer1 = new Timer();
                    //timer1.Interval = 3000;
                    //timer1.Tick += Timer1_Tick;
                    //timer1.Start();
                    label3.Text = "ok";

                }
                else
                {
                    MessageBox.Show("Error: Alguma ação não foi realisada.");
                }
            }
            else
            {
                MessageBox.Show("Error: Preencha todos os dados");
            }
        }

        private void voutar_Click(object sender, EventArgs e)
        {
            Form1 novoForm = new Form1();
            novoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 novoForm = new Form3();
            novoForm.Show();
        }
        //private void Timer1_Tick(object sender, EventArgs e)
        //{
        // Define o texto na Label
        //  label3.Text = "ok";

        // Para o Timer após o tempo definido
        //timer1.Stop();
        //}
    }
}