
namespace EthModSim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbSwitch = new System.Windows.Forms.TextBox();
            this.tbSwitchPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSend);
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatus.Location = new System.Drawing.Point(25, 277);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(730, 142);
            this.tbStatus.TabIndex = 1;
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(25, 23);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 23);
            this.tbIp.TabIndex = 2;
            this.tbIp.Text = "192.168.1.100";
            // 
            // tbSwitch
            // 
            this.tbSwitch.Location = new System.Drawing.Point(25, 78);
            this.tbSwitch.Name = "tbSwitch";
            this.tbSwitch.Size = new System.Drawing.Size(100, 23);
            this.tbSwitch.TabIndex = 3;
            this.tbSwitch.Text = "Demo-Switch";
            // 
            // tbSwitchPort
            // 
            this.tbSwitchPort.Location = new System.Drawing.Point(25, 135);
            this.tbSwitchPort.Name = "tbSwitchPort";
            this.tbSwitchPort.Size = new System.Drawing.Size(100, 23);
            this.tbSwitchPort.TabIndex = 4;
            this.tbSwitchPort.Text = "Gi1/07";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSwitchPort);
            this.Controls.Add(this.tbSwitch);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Ethernet Module Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbSwitch;
        private System.Windows.Forms.TextBox tbSwitchPort;
    }
}

