
namespace RailWay
{
    partial class formAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnTourist = new System.Windows.Forms.Button();
            this.btnFun = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 73);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(464, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель админа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1210, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 39);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Х";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panelForm);
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 612);
            this.panel1.TabIndex = 3;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(160, 73);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1097, 539);
            this.panelForm.TabIndex = 7;
            // 
            // panelControl
            // 
            this.panelControl.AutoSize = true;
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.Controls.Add(this.btnTourist);
            this.panelControl.Controls.Add(this.btnFun);
            this.panelControl.Controls.Add(this.btnPassenger);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 73);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(160, 539);
            this.panelControl.TabIndex = 6;
            // 
            // btnTourist
            // 
            this.btnTourist.AutoSize = true;
            this.btnTourist.BackColor = System.Drawing.Color.LightBlue;
            this.btnTourist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTourist.Location = new System.Drawing.Point(3, 195);
            this.btnTourist.Name = "btnTourist";
            this.btnTourist.Size = new System.Drawing.Size(154, 61);
            this.btnTourist.TabIndex = 4;
            this.btnTourist.Text = "Клиенты";
            this.btnTourist.UseVisualStyleBackColor = false;
            this.btnTourist.Click += new System.EventHandler(this.btnTourist_Click);
            // 
            // btnFun
            // 
            this.btnFun.AutoSize = true;
            this.btnFun.BackColor = System.Drawing.Color.LightBlue;
            this.btnFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFun.Location = new System.Drawing.Point(3, 306);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(154, 59);
            this.btnFun.TabIndex = 5;
            this.btnFun.Text = "Симуляция";
            this.btnFun.UseVisualStyleBackColor = false;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.AutoSize = true;
            this.btnPassenger.BackColor = System.Drawing.Color.LightBlue;
            this.btnPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassenger.Location = new System.Drawing.Point(3, 97);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(154, 60);
            this.btnPassenger.TabIndex = 3;
            this.btnPassenger.Text = "Панель";
            this.btnPassenger.UseVisualStyleBackColor = false;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdmin";
            this.Text = "adminForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnTourist;
        private System.Windows.Forms.Button btnFun;
        private System.Windows.Forms.Button btnPassenger;
    }
}