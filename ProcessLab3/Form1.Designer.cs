
namespace ProcessLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.l01 = new System.Windows.Forms.MaskedTextBox();
            this.l02 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l21 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.l30 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tk = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.T0 = new System.Windows.Forms.Label();
            this.T3 = new System.Windows.Forms.Label();
            this.T2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1004, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "lambda01";
            // 
            // l01
            // 
            this.l01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l01.Location = new System.Drawing.Point(1007, 57);
            this.l01.Mask = "000";
            this.l01.Name = "l01";
            this.l01.Size = new System.Drawing.Size(154, 22);
            this.l01.TabIndex = 1;
            this.l01.Text = "100";
            // 
            // l02
            // 
            this.l02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l02.Location = new System.Drawing.Point(1007, 111);
            this.l02.Mask = "000";
            this.l02.Name = "l02";
            this.l02.Size = new System.Drawing.Size(154, 22);
            this.l02.TabIndex = 3;
            this.l02.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1004, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "lambda02";
            // 
            // l10
            // 
            this.l10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l10.Location = new System.Drawing.Point(1007, 165);
            this.l10.Mask = "000";
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(154, 22);
            this.l10.TabIndex = 5;
            this.l10.Text = "50";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1004, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "lambda10";
            // 
            // l13
            // 
            this.l13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l13.Location = new System.Drawing.Point(1007, 220);
            this.l13.Mask = "000";
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(154, 22);
            this.l13.TabIndex = 7;
            this.l13.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1004, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "lambda13";
            // 
            // l21
            // 
            this.l21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l21.Location = new System.Drawing.Point(1007, 280);
            this.l21.Mask = "000";
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(154, 22);
            this.l21.TabIndex = 9;
            this.l21.Text = "20";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1004, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "lambda21";
            // 
            // l30
            // 
            this.l30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l30.Location = new System.Drawing.Point(1007, 343);
            this.l30.Mask = "000";
            this.l30.Name = "l30";
            this.l30.Size = new System.Drawing.Size(154, 22);
            this.l30.TabIndex = 13;
            this.l30.Text = "5";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "lambda30";
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(1007, 579);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(154, 50);
            this.Start.TabIndex = 14;
            this.Start.Text = "Смоделировать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 37);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(952, 611);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // Tk
            // 
            this.Tk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tk.Location = new System.Drawing.Point(1007, 402);
            this.Tk.Mask = "0000";
            this.Tk.Name = "Tk";
            this.Tk.Size = new System.Drawing.Size(154, 22);
            this.Tk.TabIndex = 19;
            this.Tk.Text = "1";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1004, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tk";
            // 
            // T0
            // 
            this.T0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T0.AutoSize = true;
            this.T0.Location = new System.Drawing.Point(1004, 438);
            this.T0.Name = "T0";
            this.T0.Size = new System.Drawing.Size(25, 17);
            this.T0.TabIndex = 20;
            this.T0.Text = "S0";
            // 
            // T3
            // 
            this.T3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T3.AutoSize = true;
            this.T3.Location = new System.Drawing.Point(1004, 521);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(25, 17);
            this.T3.TabIndex = 21;
            this.T3.Text = "S3";
            // 
            // T2
            // 
            this.T2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T2.AutoSize = true;
            this.T2.Location = new System.Drawing.Point(1004, 491);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(25, 17);
            this.T2.TabIndex = 22;
            this.T2.Text = "S2";
            // 
            // T1
            // 
            this.T1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T1.AutoSize = true;
            this.T1.Location = new System.Drawing.Point(1004, 464);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(25, 17);
            this.T1.TabIndex = 23;
            this.T1.Text = "S1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 660);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T0);
            this.Controls.Add(this.Tk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.l30);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l01);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox l01;
        private System.Windows.Forms.MaskedTextBox l02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox l10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox l13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox l21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox l30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MaskedTextBox Tk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label T0;
        private System.Windows.Forms.Label T3;
        private System.Windows.Forms.Label T2;
        private System.Windows.Forms.Label T1;
    }
}

