using System;
using System.Collections.Generic;
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
        private const int DadosInteirosMaxLength = 100;

        private double _tempoDadoInteiro = 0;
        private int _dadoInteiro;
        private string _dadosDoArduino;
        private PointPairList _mylist = new PointPairList();
        private bool _bStopTest = false;
        private Dictionary<double, int> _dadosInteiros = new Dictionary<double, int>();
         
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
        //001
        

        private void btn_parar_Click(object sender, EventArgs e)
        {
            TimerLeitura.Enabled = false;
            serialPort1.Close();
            _bStopTest = true;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            tbxScale.Enabled = false;   
            TimerLeitura.Enabled = true;
            _bStopTest = false;
            _mylist.Clear();
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
        private void AddDadosInteiros(double tempodadointeiro, int dadoInteiro)
        {
            if (_dadosInteiros.Count == DadosInteirosMaxLength)
            {
                _dadosInteiros.Remove(_dadosInteiros.Keys.First());
            }

            if (dadoInteiro > 0 && dadoInteiro < 20)
            {
                _dadosInteiros.Add(tempodadointeiro, dadoInteiro);
            }
        }

        private void ValidateDadosInteiros()
        {
            if (_dadosInteiros.Count < DadosInteirosMaxLength) 
            {
                return;
            }

            var lastY = _dadosInteiros.Keys.Last();
            var firstY = _dadosInteiros.Keys.First();

            var lastX = _dadosInteiros.Values.Last();
            var firstX = _dadosInteiros.Values.First();



            var difference = Math.Truncate((_dadosInteiros.Keys.Last() - _dadosInteiros.Keys.First()) / (_dadosInteiros.Values.Last() - _dadosInteiros.Values.First())) / 100;
            var isInfinity = difference == double.PositiveInfinity || difference == double.NegativeInfinity;

            StatusSeguranca.Text = isInfinity ? "0" : difference.ToString();

            /*if (difference >= 2) 
            {
                StatusSeguranca.Text = "Perigo!";
                StatusSeguranca.ForeColor = Color.Red;
            }*/

        }

        private void leitura()
        {
            serialPort1.Open();

            //002

            if (serialPort1.IsOpen == true)
            {
                string valor;
                serialPort1.Write("A");
                valor = serialPort1.ReadLine();
                valor = valor?.Split(new[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()?.Trim();
                if (!string.IsNullOrEmpty(valor))  {
                    try
                    {
                        _dadoInteiro = int.Parse(valor);
                        lblStatus2.Text = "OK!";
                        if (_dadoInteiro < 15)
                        {
                            StatusSeguranca.Text = "Nível estável.";
                            StatusSeguranca.ForeColor = Color.Green;
                        }
                        else
                        {
                            StatusSeguranca.Text = "Possível inundação iminente!";
                            StatusSeguranca.ForeColor = Color.Red;

                        }
                    }
                    catch (FormatException)
                    {
                        lblStatus2.Text = "Erro: o valor da string não é um número válido.";
                        _dadoInteiro = 0;
                    }
                    catch (OverflowException)
                    {
                        lblStatus2.Text = ("Erro: o valor da string está fora do intervalo de um inteiro.");
                        _dadoInteiro = 0;
                    }
                }

                if (string.IsNullOrWhiteSpace(valor) || valor == "0")
                {
                    lblStatus.Text = "ERRO!!!";
                }
                else
                {
                    lblStatus.Text = valor + "cm";
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
            LineItem myCurve = myPane.AddCurve("", _mylist, Color.Blue, SymbolType.Circle);

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
            //double time = 0;
            //float fStartDegree = 0;
            while (true)
            {
                // Verifica se o valor de DadosInteiros é 0
                if (_dadoInteiro != 0)
                {
                    //Math.Sin(Math.PI * DadosInteiros / 100));
                    _mylist.Add(_tempoDadoInteiro, _dadoInteiro);
                    _tempoDadoInteiro++;
                    Controlador = _dadoInteiro;
                }
                else
                {
                    Controlador = _dadoInteiro;
                    //Math.Sin(Math.PI * DadosInteiros / 100));
                    _mylist.Add(_tempoDadoInteiro, _dadoInteiro);
                    _tempoDadoInteiro++;
                }
                //AddDadosInteiros(_tempoDadoInteiro, _dadoInteiro);
                //ValidateDadosInteiros();

                UpdateGraph();
                Thread.Sleep(500);
                if (_bStopTest)
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
            serialPort1.PortName = combobox_portas.Text;
            combobox_portas.Enabled = false;
            

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
                combobox_portas.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combobox_portas.Enabled = true;
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
            /*if (porta_text.Text == "Selecione a porta")
            {
                porta_text.Text = "";
                porta_text.ForeColor = Color.Black; // Muda a cor do texto para normal quando o usuário começa a digitar
            }*/
        }

        private void porta_text_Leave_1(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(porta_text.Text))
            {
                porta_text.Text = "Selecione a porta";
                porta_text.ForeColor = Color.Gray; // Muda a cor do texto para indicar que é uma dica
            }*/
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Teste().GetAwaiter().GetResult();
        }

        /*private async Task Teste()
        {
            int d1int;
            int d2int;
            serialPort1.Open();
            string d1 = serialPort1.ReadLine();
            d1int = int.Parse(d1);

            await Task.Delay(3000);
            
            string d2 = serialPort1.ReadLine();
            d2int = int.Parse(d2);
            serialPort1.Close();
        }*/
    }

    /*001
         * 
         * private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
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

    /*002
             * 
             * DadosDoArduino = serialPort1.ReadExisting();
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

}
