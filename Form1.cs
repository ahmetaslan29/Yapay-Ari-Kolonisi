using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Y.Arıkolonisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random rnd = new Random();

      
    

        private void btn_calistir_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
            listbox2.Items.Clear();
            chart1.Series.Clear();
            int koloniBoyutu = Convert.ToInt32(txtkoloni.Text);
            int Iterasyon = Convert.ToInt32(txtiterasyon.Text);
            int ProblemBoyutu = 2;

            Kaynak kaynak = new Kaynak(koloniBoyutu, ProblemBoyutu, Ackleyfunction.aldeger, Ackleyfunction.ustdeger);
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Name = "Grafik";
            for (int i = 0; i < Iterasyon; i++)
            {
                kaynak.Cozumdegerlerihesapla();//işçi arılar
                kaynak.Phesabı();
                kaynak.Gozcuarı();
                kaynak.kasifkaynakara();
                listbox2.Items.Add(kaynak.bestfitness.ToString("0.#######"));




                series.Points.Add(new DataPoint(i + 1, kaynak.bestfitness));


            }
            chart1.Series.Add(series);
            for (int i = 0; i < koloniBoyutu / 2; i++)
            {
                for (int j = 0; j < ProblemBoyutu; j++)
                {
                    listbox1.Items.Add(kaynak.kaynak[i, j].ToString("0.#######"));
                }
                listbox1.Items.Add("--------------");
            }
            kaynak.uygunlukvefitnesshesabı();
        }
    }
}
