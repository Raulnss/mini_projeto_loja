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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

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
                        var veri = new MySqlCommand("SELECT cd_produto,nm_produto FROM produtos WHERE cd_produto = @cd AND nm_produto = @nome", cn);
                        veri.Parameters.AddWithValue("@cd", cd);
                        veri.Parameters.AddWithValue("@nome", name);

                        var reader = veri.ExecuteReader();

                        if (reader.Read())
                        {
                            n1 = true;
                            var no = reader["nm_produto"].ToString();
                            var qu = reader["cd_produto"].ToString();
                            label3.Text = "";
                            label3.Text += "\n Código: "+qu+" nome: "+no + "\n";
                            while (reader.Read())
                            {
                                string nm = reader["cd_produto"].ToString();
                                string qt = reader["nm_produto"].ToString();
                                label3.Text += "\n Código: "+nm+" nome: "+qt+ "\n";
                            }
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
            }
            else if (!string.IsNullOrWhiteSpace(cd))
            {
                try
                {
                    using (var cn = new MySqlConnection(Conn.strConn))
                    {
                        cn.Open();
                        var veri = new MySqlCommand("SELECT cd_produto,nm_produto FROM produtos WHERE cd_produto = @cd", cn);
                        veri.Parameters.AddWithValue("@cd", cd);
                        var reader = veri.ExecuteReader();

                        if (reader.Read())
                        {
                            n1 = true;
                            var no = reader["nm_produto"].ToString();
                            var qu = reader["cd_produto"].ToString();
                            label3.Text = "";
                            label3.Text += "\n Código: " + qu + " nome: " + no + "\n";
                            while (reader.Read())
                            {
                                string nm = reader["cd_produto"].ToString();
                                string qt = reader["nm_produto"].ToString();
                                label3.Text += "\n Código: " + nm + " nome: " + qt + "\n";
                            }
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
            }
            else if (!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    using (var cn = new MySqlConnection(Conn.strConn))
                    {
                        cn.Open();
                        var veri = new MySqlCommand("SELECT cd_produto,nm_produto FROM produtos WHERE nm_produto = @nome", cn);
                        veri.Parameters.AddWithValue("@nome", name);
                        var reader = veri.ExecuteReader();

                        if (reader.Read())
                        {
                            n1 = true;
                            var no = reader["nm_produto"].ToString();
                            var qu = reader["cd_produto"].ToString();
                            label3.Text = "";
                            label3.Text += "\n Código: " + qu + " nome: " + no + "\n";
                            while (reader.Read())
                            {
                                string nm = reader["cd_produto"].ToString();
                                string qt = reader["nm_produto"].ToString();
                                label3.Text += "\n Código: " + nm + " nome: " + qt + "\n";
                            }
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
            }
            else
            {
                MessageBox.Show("Error: Forneça algum dado.");
            }
        }

        private void voutar_Click(object sender, EventArgs e)
        {
            Form1 novoForm = new Form1();
            novoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2();
            novoForm.Show();
        }
    }
}
