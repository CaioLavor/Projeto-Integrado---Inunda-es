﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NivelDeAgua
{
    public partial class Form1 : Form
    {
        int DadosInteiros;
        String DadosDoArduino;
        PointPairList myList = new PointPairList();
        bool bStopTest = false;
        public Form1()
        {
            InitializeComponent();
            //serialPort1.Open();
            initGraph();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
        }

        /*private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DadosDoArduino = serialPort1.ReadExisting();
            if (!string.IsNullOrEmpty(DadosDoArduino))
            {
                String CaractereIndesejado = "-";
                var MaxIndex = DadosDoArduino.Length < 2 ? 1 : 2;
                DadosDoArduino = DadosDoArduino.Substring(0, MaxIndex);
                if (DadosDoArduino.Contains(CaractereIndesejado)) 
                {
                    DadosDoArduino = "0";
                    DadosInteiros = int.Parse(DadosDoArduino);
                    
                } else
                {
                    DadosInteiros = int.Parse(DadosDoArduino);
                }
                if (DadosInteiros > 20)
                {
                    // Converte a string para um array de caracteres para manipulação
                    char[] chars = Convert.ToString(DadosInteiros).ToCharArray();

                    // Troca os caracteres na posição 0 e 1
                    char temp = chars[0];
                    chars[0] = chars[1];
                    chars[1] = temp;

                    // Converte o array de volta para uma string
                    string result = new string(chars);

                    DadosInteiros = int.Parse(result);
                }

            }

        }*/

        private void btn_parar_Click(object sender, EventArgs e)
        {
            TimerLeitura.Enabled = false;
            serialPort1.Close();
            bStopTest = true;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            tbxScale.Enabled = false;   
            TimerLeitura.Enabled = true;
            bStopTest = false;
            myList.Clear();
            Thread plotThread = new Thread(new ThreadStart(CalculateAndFill));
            plotThread.Start();
        }

        private void tbxScale_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimerLeitura_Tick(object sender, EventArgs e)
        {
            leitura();
        }
        private void leitura()
        {
            serialPort1.Open();

            /*DadosDoArduino = serialPort1.ReadExisting();
            if (!string.IsNullOrEmpty(DadosDoArduino))
            {
                String CaractereIndesejado = "-";
                var MaxIndex = DadosDoArduino.Length < 2 ? 1 : 2;
                DadosDoArduino = DadosDoArduino.Substring(0, MaxIndex);
                if (DadosDoArduino.Contains(CaractereIndesejado))
                {
                    DadosDoArduino = "0";
                    DadosInteiros = int.Parse(DadosDoArduino);

                }
                else
                {
                    DadosInteiros = int.Parse(DadosDoArduino);
                }
                if (DadosInteiros > 20)
                {
                    // Converte a string para um array de caracteres para manipulação
                    char[] chars = Convert.ToString(DadosInteiros).ToCharArray();

                    // Troca os caracteres na posição 0 e 1
                    char temp = chars[0];
                    chars[0] = chars[1];
                    chars[1] = temp;

                    // Converte o array de volta para uma string
                    string result = new string(chars);

                    DadosInteiros = int.Parse(result);
                }

            }*/

            if (serialPort1.IsOpen == true)
            {
                string valor;
                serialPort1.Write("A");
                valor = serialPort1.ReadLine();
                valor = valor?.Split(new[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()?.Trim();
                if (!string.IsNullOrEmpty(valor))  {
                    try
                    {
                        DadosInteiros = int.Parse(valor);
                        lblStatus2.Text = "OK!";
                    }
                    catch (FormatException)
                    {
                        lblStatus2.Text = "Erro: o valor da string não é um número válido.";
                        DadosInteiros = 0;
                    }
                    catch (OverflowException)
                    {
                        lblStatus2.Text = ("Erro: o valor da string está fora do intervalo de um inteiro.");
                        DadosInteiros = 0;
                    }
                }

                if (string.IsNullOrWhiteSpace(valor) || valor == "0")
                {
                    lblStatus.Text = "ERRO!!!";
                }
                else
                {
                    lblStatus.Text = valor;
                }
            }
            serialPort1.Close();
        }
        private void initGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            myPane.Title.Text = "Nível de Água";
            myPane.XAxis.Title.Text = "Tempo";
            myPane.YAxis.Title.Text = "Nível";

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            myPane.Chart.Fill = new Fill(Color.White, Color.LightBlue, 45.0f);
            LineItem myCurve = myPane.AddCurve("", myList, Color.Blue, SymbolType.Circle);

            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 5;
        }

        private void UpdateGraph()
        {
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Update();
            zedGraphControl1.Refresh();
        }
        private void CalculateAndFill()
        {
            int Controlador = 0;
            double time = 0;
            //float fStartDegree = 0;
            while (true)
            {
                // Verifica se o valor de DadosInteiros é 0
                if (DadosInteiros != 0)
                {
                    //Math.Sin(Math.PI * DadosInteiros / 100));
                    myList.Add(time, DadosInteiros);
                    time++;
                    Controlador = DadosInteiros;
                }
                else
                {
                    Controlador = DadosInteiros;
                    //Math.Sin(Math.PI * DadosInteiros / 100));
                    myList.Add(time, DadosInteiros);
                    time++;
                }

                UpdateGraph();
                Thread.Sleep(500);
                if (bStopTest)
                {
                    break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = porta_text.Text;
            porta_text.Enabled = false;
            

            try
            {
                serialPort1.Open();
                MessageBox.Show("Conexão bem sucedida");
                btn_iniciar.Enabled = true;
                btn_parar.Enabled = true;
                serialPort1.Close();
            }
            catch 
            {
                MessageBox.Show("Conexão sem sucesso!");
                porta_text.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            porta_text.Enabled = true;
            btn_iniciar.Enabled = false;
            btn_parar.Enabled = false;
            serialPort1.Close();
        }

        private void porta_text_TextChanged(object sender, EventArgs e)
        {
            //porta_text.Text = "";
        }
        private void porta_text_Enter(object sender, EventArgs e)
        {
            
        }

        private void porta_text_Leave(object sender, EventArgs e)
        {
           
        }

        private void porta_text_Enter_1(object sender, EventArgs e)
        {
            if (porta_text.Text == "Selecione a porta")
            {
                porta_text.Text = "";
                porta_text.ForeColor = Color.Black; // Muda a cor do texto para normal quando o usuário começa a digitar
            }
        }

        private void porta_text_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(porta_text.Text))
            {
                porta_text.Text = "Selecione a porta";
                porta_text.ForeColor = Color.Gray; // Muda a cor do texto para indicar que é uma dica
            }
        }
    }
}
