using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Loja_do_Andre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string cd = codigo.Text;
            string name = nome.Text;
            cd = cd.Trim();
            name = name.Trim();
            cd = cd.ToLower();
            name = name.ToLower();
           /* cd = cd.Normalize(NormalizationForm.FormD).Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a")
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
        .Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "")
        .Replace("´", "").Replace("¸", "").Replace("^", "").Replace("~", "");
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
        .Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "")
        .Replace("´", "").Replace("¸", "").Replace("^", "").Replace("~", "");*/
            /*cd = new string(cd.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
            name = new string(name.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
            cd = Regex.Replace(cd, @"[^a-zA-Z0-9 ]", "");
            name = Regex.Replace(name, @"[^a-zA-Z0-9 ]", "");*/
            string valor_co = "";
            bool n1 = true;
            bool n2 = false;
            if (!string.IsNullOrWhiteSpace(cd) && !string.IsNullOrWhiteSpace(name))
            {
                try
                {
                  using ( var cn = new MySqlConnection(Conn.strConn))
                    {
                    cn.Open();
                    var veri = new MySqlCommand("SELECT * FROM produtos WHERE cd_produto = @cd AND nm_produto = @nome", cn);
                    veri.Parameters.AddWithValue("@cd", cd);
                    veri.Parameters.AddWithValue("@nome", name);

                    var reader = veri.ExecuteReader();

                    if (reader.Read())
                    {
                     MessageBox.Show("Error: Produto já cadastrado.");
                        n1 = false;
                    }
                    cn.Close();
                }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                if (n1 == true)
                    {
                    try
                    {
                     using (var cn1 = new MySqlConnection(Conn.strConn))
                      {
                        cn1.Open();
                        var cadas = new MySqlCommand("INSERT INTO produtos(cd_produto,nm_produto) VALUES(@cd, @nome)", cn1);
                        cadas.Parameters.AddWithValue("@cd", cd);
                        cadas.Parameters.AddWithValue("@nome", name);
                        cadas.ExecuteNonQuery();
                        cn1.Close();
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                    try
                    {
                    using (var cn2 = new MySqlConnection(Conn.strConn)) { 
                    cn2.Open(); 
                      var veri2 = new MySqlCommand("SELECT * FROM quantidade WHERE nm_produto = @nome", cn2);
                     veri2.Parameters.AddWithValue("@nome", name);
                     var reader2 = veri2.ExecuteReader();
                     if (reader2.Read())
                     {
                          var dado = reader2["qt_produto"].ToString();
                          int valor = int.Parse(dado);
                          valor++;
                          valor_co = valor.ToString();
                          n2 = true;
                     }
                     else
                      { 
                         n2 = false;
                     }
                     cn2.Close();
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                    if (n2 == true)
                    {
                        try
                        {
                         using (var cn3 = new MySqlConnection(Conn.strConn)) { 
                        cn3.Open();
                            var vl_up = valor_co;
                            var up = new MySqlCommand("UPDATE quantidade SET qt_produto = @valor WHERE nm_produto = @nome", cn3);
                            up.Parameters.AddWithValue("@valor", vl_up);
                            up.Parameters.AddWithValue("@nome", name);
                            up.ExecuteNonQuery();
                            cn3.Close();
                        } 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        
                    }
                    else
                    {
                        try
                        {
                        using (var cn4 = new MySqlConnection(Conn.strConn))
                         {
                            cn4.Open();
                            var cadas2 = new MySqlCommand("INSERT INTO quantidade(nm_produto,qt_produto) VALUES(@nome, @qt)", cn4);
                            cadas2.Parameters.AddWithValue("@nome", name);
                            cadas2.Parameters.AddWithValue("@qt", 1);
                            cadas2.ExecuteNonQuery();
                            cn4.Close();
                         }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        
                    }
                }
                try
                {
                using (var cn5 = new MySqlConnection(Conn.strConn))
                {
                    cn5.Open();
                    var veri3 = new MySqlCommand("SELECT qt_produto FROM quantidade WHERE nm_produto = @nome", cn5);
                    veri3.Parameters.AddWithValue("@nome", name);
                    var reader3 = veri3.ExecuteReader();
                    if (reader3.Read())
                    {
                        var dado3 = reader3["qt_produto"].ToString();
                        L_qt_pd_cadastrado.Text = "O produto: "+name+"; tem essa quantidade: "+dado3;
                    }
                    else
                    {
                        MessageBox.Show("Error: não identificado");
                    }
                        cn5.Close();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Error: Preencha todos os dados.");
            }
        }

        private void ver_qt_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn6 = new MySqlConnection(Conn.strConn))
                {
                    cn6.Open();
                    var veri4 = new MySqlCommand("SELECT * FROM quantidade", cn6);
                    var reader4 = veri4.ExecuteReader();
                    if (reader4.Read())
                    {
                        var nnm = reader4["nm_produto"].ToString();
                        var qqt = reader4["qt_produto"].ToString();
                        label3.Text = "";
                        label3.Text += "\n"+nnm+" tem: "+qqt+"\n";
                        while (reader4.Read())
                        {
                            string nm = reader4.GetString(1);
                            string qt = reader4.GetString(2);
                            label3.Text += "\n"+nm+" tem: "+qt+"\n";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Nenhum produto encontrado.");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vender_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2();
            novoForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 novoForm = new Form3();
            novoForm.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
} 