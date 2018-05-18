namespace ChatWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.comboBoxListUsers = new System.Windows.Forms.ComboBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxShowMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(43, 36);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentUser.TabIndex = 0;
            // 
            // comboBoxListUsers
            // 
            this.comboBoxListUsers.FormattingEnabled = true;
            this.comboBoxListUsers.Location = new System.Drawing.Point(47, 80);
            this.comboBoxListUsers.Name = "comboBoxListUsers";
            this.comboBoxListUsers.Size = new System.Drawing.Size(121, 28);
            this.comboBoxListUsers.TabIndex = 1;
            this.comboBoxListUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxListUsers_SelectedIndexChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(47, 142);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(156, 26);
            this.textBoxMessage.TabIndex = 2;
            // 
            // textBoxShowMessage
            // 
            this.textBoxShowMessage.Location = new System.Drawing.Point(257, 80);
            this.textBoxShowMessage.Multiline = true;
            this.textBoxShowMessage.Name = "textBoxShowMessage";
            this.textBoxShowMessage.Size = new System.Drawing.Size(498, 314);
            this.textBoxShowMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(47, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 33);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBoxShowMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.comboBoxListUsers);
            this.Controls.Add(this.lblCurrentUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ComboBox comboBoxListUsers;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxShowMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

