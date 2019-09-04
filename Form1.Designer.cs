namespace Y.Arıkolonisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox2 = new System.Windows.Forms.ListBox();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.btn_calistir = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtkoloni = new System.Windows.Forms.TextBox();
            this.txtiterasyon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "İterasyon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Koloni Boyutu";
            // 
            // listbox2
            // 
            this.listbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox2.FormattingEnabled = true;
            this.listbox2.ItemHeight = 16;
            this.listbox2.Location = new System.Drawing.Point(290, 39);
            this.listbox2.Name = "listbox2";
            this.listbox2.Size = new System.Drawing.Size(174, 324);
            this.listbox2.TabIndex = 12;
            // 
            // listbox1
            // 
            this.listbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 16;
            this.listbox1.Location = new System.Drawing.Point(145, 119);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(126, 244);
            this.listbox1.TabIndex = 13;
            // 
            // btn_calistir
            // 
            this.btn_calistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calistir.Location = new System.Drawing.Point(145, 398);
            this.btn_calistir.Name = "btn_calistir";
            this.btn_calistir.Size = new System.Drawing.Size(319, 42);
            this.btn_calistir.TabIndex = 11;
            this.btn_calistir.Text = "Çalıştır";
            this.btn_calistir.UseVisualStyleBackColor = true;
            this.btn_calistir.Click += new System.EventHandler(this.btn_calistir_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 1.2D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(512, 65);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Grafik";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(693, 317);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // txtkoloni
            // 
            this.txtkoloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkoloni.Location = new System.Drawing.Point(145, 39);
            this.txtkoloni.Name = "txtkoloni";
            this.txtkoloni.Size = new System.Drawing.Size(126, 22);
            this.txtkoloni.TabIndex = 21;
            this.txtkoloni.Text = "10";
            this.txtkoloni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtiterasyon
            // 
            this.txtiterasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtiterasyon.Location = new System.Drawing.Point(145, 90);
            this.txtiterasyon.Name = "txtiterasyon";
            this.txtiterasyon.Size = new System.Drawing.Size(126, 22);
            this.txtiterasyon.TabIndex = 22;
            this.txtiterasyon.Text = "100";
            this.txtiterasyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1229, 452);
            this.Controls.Add(this.txtiterasyon);
            this.Controls.Add(this.txtkoloni);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox2);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.btn_calistir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox2;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button btn_calistir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtkoloni;
        private System.Windows.Forms.TextBox txtiterasyon;
    }
}

