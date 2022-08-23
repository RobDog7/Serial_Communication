namespace Serial_Communication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvailablePortsBox = new System.Windows.Forms.ComboBox();
            this.ConnectToPort = new System.Windows.Forms.Button();
            this.RecievedDataBox = new System.Windows.Forms.TextBox();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.SendSerialButton = new System.Windows.Forms.Button();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FileSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AvailablePorts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recieved Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Command";
            // 
            // AvailablePortsBox
            // 
            this.AvailablePortsBox.FormattingEnabled = true;
            this.AvailablePortsBox.Location = new System.Drawing.Point(12, 32);
            this.AvailablePortsBox.Name = "AvailablePortsBox";
            this.AvailablePortsBox.Size = new System.Drawing.Size(121, 21);
            this.AvailablePortsBox.TabIndex = 3;
            // 
            // ConnectToPort
            // 
            this.ConnectToPort.Location = new System.Drawing.Point(12, 59);
            this.ConnectToPort.Name = "ConnectToPort";
            this.ConnectToPort.Size = new System.Drawing.Size(75, 23);
            this.ConnectToPort.TabIndex = 4;
            this.ConnectToPort.Text = "Connect";
            this.ConnectToPort.UseVisualStyleBackColor = true;
            this.ConnectToPort.Click += new System.EventHandler(this.ConnectToPort_Click);
            // 
            // RecievedDataBox
            // 
            this.RecievedDataBox.Location = new System.Drawing.Point(12, 139);
            this.RecievedDataBox.Multiline = true;
            this.RecievedDataBox.Name = "RecievedDataBox";
            this.RecievedDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecievedDataBox.Size = new System.Drawing.Size(129, 159);
            this.RecievedDataBox.TabIndex = 5;
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(12, 350);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(129, 20);
            this.SenderTextBox.TabIndex = 6;
            // 
            // SendSerialButton
            // 
            this.SendSerialButton.Location = new System.Drawing.Point(16, 376);
            this.SendSerialButton.Name = "SendSerialButton";
            this.SendSerialButton.Size = new System.Drawing.Size(75, 23);
            this.SendSerialButton.TabIndex = 7;
            this.SendSerialButton.Text = "Send";
            this.SendSerialButton.UseVisualStyleBackColor = true;
            this.SendSerialButton.Click += new System.EventHandler(this.SendSerialButton_Click);
            // 
            // DataChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DataChart.Legends.Add(legend2);
            this.DataChart.Location = new System.Drawing.Point(183, 32);
            this.DataChart.Name = "DataChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DataChart.Series.Add(series2);
            this.DataChart.Size = new System.Drawing.Size(542, 391);
            this.DataChart.TabIndex = 8;
            this.DataChart.Text = "chart1";
            // 
            // FileSaveCheckBox
            // 
            this.FileSaveCheckBox.AutoSize = true;
            this.FileSaveCheckBox.Location = new System.Drawing.Point(16, 421);
            this.FileSaveCheckBox.Name = "FileSaveCheckBox";
            this.FileSaveCheckBox.Size = new System.Drawing.Size(86, 17);
            this.FileSaveCheckBox.TabIndex = 9;
            this.FileSaveCheckBox.Text = "Save To File";
            this.FileSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileSaveCheckBox);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.SendSerialButton);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.RecievedDataBox);
            this.Controls.Add(this.ConnectToPort);
            this.Controls.Add(this.AvailablePortsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AvailablePortsBox;
        private System.Windows.Forms.Button ConnectToPort;
        private System.Windows.Forms.TextBox RecievedDataBox;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Button SendSerialButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.CheckBox FileSaveCheckBox;
        private System.Windows.Forms.Timer timer1;
    }
}

