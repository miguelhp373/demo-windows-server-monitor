namespace demo_server_monitor
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ram_info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cpu_speed_info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cpu_temperature_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_ram_info);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(460, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 113);
            this.panel3.TabIndex = 6;
            // 
            // lbl_ram_info
            // 
            this.lbl_ram_info.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ram_info.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_ram_info.Location = new System.Drawing.Point(3, 63);
            this.lbl_ram_info.Name = "lbl_ram_info";
            this.lbl_ram_info.Size = new System.Drawing.Size(183, 28);
            this.lbl_ram_info.TabIndex = 1;
            this.lbl_ram_info.Text = "0%";
            this.lbl_ram_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "RAM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_cpu_speed_info);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 113);
            this.panel2.TabIndex = 7;
            // 
            // lbl_cpu_speed_info
            // 
            this.lbl_cpu_speed_info.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_speed_info.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_cpu_speed_info.Location = new System.Drawing.Point(3, 63);
            this.lbl_cpu_speed_info.Name = "lbl_cpu_speed_info";
            this.lbl_cpu_speed_info.Size = new System.Drawing.Size(183, 28);
            this.lbl_cpu_speed_info.TabIndex = 1;
            this.lbl_cpu_speed_info.Text = "0%";
            this.lbl_cpu_speed_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_cpu_temperature_info);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(235, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 113);
            this.panel1.TabIndex = 8;
            // 
            // lbl_cpu_temperature_info
            // 
            this.lbl_cpu_temperature_info.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_temperature_info.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_cpu_temperature_info.Location = new System.Drawing.Point(3, 63);
            this.lbl_cpu_temperature_info.Name = "lbl_cpu_temperature_info";
            this.lbl_cpu_temperature_info.Size = new System.Drawing.Size(183, 28);
            this.lbl_cpu_temperature_info.TabIndex = 1;
            this.lbl_cpu_temperature_info.Text = "0ºC";
            this.lbl_cpu_temperature_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "menu";
            this.Text = "demo-server-monitor-beta";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_ram_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cpu_speed_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cpu_temperature_info;
        private System.Windows.Forms.Label label1;
    }
}

