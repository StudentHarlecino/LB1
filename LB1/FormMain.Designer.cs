namespace LB1
{
    partial class FormMain
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
            panelTop = new Panel();
            labelUser = new Label();
            panel2 = new Panel();
            labelInfAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUser);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 80);
            panelTop.TabIndex = 0;
            // 
            // labelUser
            // 
            labelUser.Dock = DockStyle.Fill;
            labelUser.Font = new Font("Segoe UI", 14.25F);
            labelUser.Location = new Point(10, 10);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(780, 60);
            labelUser.TabIndex = 0;
            labelUser.Text = "Список  пользователей:";
            labelUser.TextAlign = ContentAlignment.TopCenter;
            labelUser.Click += labelUser_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInfAboutUsers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(800, 370);
            panel2.TabIndex = 1;
            // 
            // labelInfAboutUsers
            // 
            labelInfAboutUsers.Dock = DockStyle.Fill;
            labelInfAboutUsers.Location = new Point(10, 10);
            labelInfAboutUsers.Name = "labelInfAboutUsers";
            labelInfAboutUsers.Size = new Size(780, 350);
            labelInfAboutUsers.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Label labelUser;
        private Label labelInfAboutUsers;
    }
}
