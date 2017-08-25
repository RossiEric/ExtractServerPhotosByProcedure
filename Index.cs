using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace ExtractServerPhotosWithProcedure
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // vamos obter a conexão com o banco de dados
            SqlConnection conn = Conexao.obterConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else
            {
                MessageBox.Show("A conexão foi obtida com sucesso.");
            }

            // não precisamos mais da conexão? vamos fechá-la
            Conexao.fecharConexao();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string strURLpadrao = tb_url.Text;
            string strProcUsar = tb_proc.Text;
            string strNomePasta = "BKP_" + DateTime.Now.ToString("yyyy-dd-M_HH-mm-ss") + "_PROC_" + strProcUsar;
            string strCaminhoNivel1 = @""+ tb_caminho_local.Text + "" + strNomePasta;
            string strPastaDonwload = "";
            //string strCaminhoURLfinal = "":
            textBox1.Clear();
            int contador = 0;

            checkTeste.Enabled = false;

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(strCaminhoNivel1))
                {
                    textBox1.AppendText("Pasta já existe");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(strCaminhoNivel1);
                textBox1.AppendText("Pasta principal criada: " + strNomePasta + "\r\n");

                //loop
                SqlConnection conn = Conexao.obterConexao();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = strProcUsar;
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("ParameterName", parameter);

                try
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {

                        if (await reader.ReadAsync())
                        {

                            //Donwload do primeiro arquivo
                                    //verificar pasta e se já existe
                                    if (Directory.Exists(strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString()))
                                    {
                                        //Console.WriteLine("Pasta já existe");
                                        //return;
                                    }
                                    else
                                    {
                                        strPastaDonwload = strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString() + "\\";

                                        DirectoryInfo di_proc = Directory.CreateDirectory(strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString());
                                        textBox1.AppendText("SubPasta criada: " + reader["Pasta_DP"].ToString() + " \r\n");
                                    }

                                    if (!string.IsNullOrEmpty(reader["Caminho_Foto"].ToString()) && !string.IsNullOrEmpty(reader["Nome_Foto"].ToString()))
                                    {

                                        var strCaminhoURLfinal = reader["Caminho_Foto"].ToString().Replace("~", strURLpadrao);
                                        textBox1.AppendText("[" + contador + "] - Inicio Download: " + strCaminhoURLfinal + " COMO: " + strPastaDonwload + reader["Nome_Foto"].ToString() + " \r\n");

                                        //salvar foto
                                        using (WebClient webClient = new WebClient())
                                        {
                                            webClient.DownloadFile(strCaminhoURLfinal, strPastaDonwload + reader["Nome_Foto"].ToString());
                                        }

                                        textBox1.AppendText("[" + contador + "] - Download Concluido: " + strPastaDonwload + reader["Nome_Foto"].ToString() + " \r\n");

                                    }
                            //Donwload do primeiro arquivo

                            //lista
                            while (await reader.ReadAsync())
                            {
                                //MessageBox.Show(reader["Pasta_DP"].ToString());

                                contador++;

                                //ReadSingleRow((IDataRecord)reader);

                                if (!string.IsNullOrEmpty(reader["Pasta_DP"].ToString()))
                                {

                                    //verificar pasta e se já existe
                                    if (Directory.Exists(strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString()))
                                    {
                                        //Console.WriteLine("Pasta já existe");
                                        //return;
                                    }
                                    else
                                    {
                                        strPastaDonwload = strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString() + "\\";

                                        DirectoryInfo di_proc = Directory.CreateDirectory(strCaminhoNivel1 + "\\" + reader["Pasta_DP"].ToString());
                                        textBox1.AppendText("SubPasta criada: " + reader["Pasta_DP"].ToString() + " \r\n");
                                    }

                                    if (!string.IsNullOrEmpty(reader["Caminho_Foto"].ToString()) && !string.IsNullOrEmpty(reader["Nome_Foto"].ToString()))
                                    {

                                        var strCaminhoURLfinal = reader["Caminho_Foto"].ToString().Replace("~", strURLpadrao);
                                        textBox1.AppendText("[" + contador + "] - Inicio Download: " + strCaminhoURLfinal + " COMO: " + strPastaDonwload + reader["Nome_Foto"].ToString() + " \r\n");

                                        //salvar foto
                                        using (WebClient webClient = new WebClient())
                                        {
                                            webClient.DownloadFile(strCaminhoURLfinal, strPastaDonwload + reader["Nome_Foto"].ToString());
                                        }

                                        textBox1.AppendText("[" + contador + "] - Download Concluido: " + strPastaDonwload + reader["Nome_Foto"].ToString() + " \r\n");

                                        show_contador.Text = "Total de fotos: " + contador.ToString();
                                    }
                                    else
                                    {
                                        textBox1.AppendText("[" + contador + "] - NULL \r\n");
                                    }

                                    if (checkTeste.Checked)
                                    {
                                        if (contador == 10)
                                        {
                                            return;
                                        }
                                    }
                                    
                                    

                                }

                            }
                        }
                    }

                    textBox1.AppendText("CONCLUIDO!\r\n");
                    Conexao.fecharConexao();
                    checkTeste.Enabled = true;
                }
                catch
                {
                    textBox1.AppendText("CONCLUIDO!\r\n");
                    Conexao.fecharConexao();
                    checkTeste.Enabled = true;
                    throw;
                }
                //loop

            }
            catch (Exception ex)
            {
                textBox1.AppendText("CONCLUIDO!\r\n");
                textBox1.AppendText(ex.ToString());
                checkTeste.Enabled = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n\r\n\r\n###########################################################\r\n");
            textBox1.AppendText("URL:\r\n");
            textBox1.AppendText("- Adicionar 'Barra Invertida' ou não ao final da URL depende do retorno da PROC, aqui prevemos que o caminho da foto inicie com '~/'. De outra forma não funcionara.\r\n");
            textBox1.AppendText("- Caso a PROC traga o caminho completo das fotos, deixar campo URL em branco.\r\n\r\n");
            textBox1.AppendText("PROC:\r\n");
            textBox1.AppendText("- A PROC não deve receber nenhum parametro.\r\n");
            textBox1.AppendText("- Serão usados os campos:\r\n");
            textBox1.AppendText("String Pasta_DP,\r\n");
            textBox1.AppendText("String Caminho_Foto,\r\n");
            textBox1.AppendText("String Nome_Foto\r\n\r\n");
            textBox1.AppendText("Salvar em:\r\n");
            textBox1.AppendText("- Caminho deve usar 'Barra Invertida'\r\n");
            textBox1.AppendText("- Deve terminar com 'Barra Invertida'\r\n");
            textBox1.AppendText("###########################################################\r\n\r\n\r\n");
        }
    }
}
