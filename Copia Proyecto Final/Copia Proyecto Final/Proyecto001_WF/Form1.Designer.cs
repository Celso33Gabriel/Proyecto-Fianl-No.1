namespace Proyecto001_WF
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            TB_Prompt = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnCerra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.pngimg_com___chatgpt_PNG2;
            pictureBox1.Location = new Point(215, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(611, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 141);
            label1.TabIndex = 1;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(296, 225);
            label4.Name = "label4";
            label4.Size = new Size(326, 29);
            label4.TabIndex = 4;
            label4.Text = "¿Con qué puedo ayudarte?";
            // 
            // TB_Prompt
            // 
            TB_Prompt.BackColor = SystemColors.InactiveCaption;
            TB_Prompt.Location = new Point(215, 281);
            TB_Prompt.Margin = new Padding(3, 4, 3, 4);
            TB_Prompt.Name = "TB_Prompt";
            TB_Prompt.Size = new Size(485, 27);
            TB_Prompt.TabIndex = 5;
            TB_Prompt.TextChanged += TB_Prompt_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.RosyBrown;
            btnBuscar.Location = new Point(409, 320);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_ClickAsync;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.AppWorkspace;
            btnLimpiar.Location = new Point(249, 320);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 28);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerra
            // 
            btnCerra.BackColor = Color.Red;
            btnCerra.Location = new Point(558, 323);
            btnCerra.Name = "btnCerra";
            btnCerra.Size = new Size(79, 28);
            btnCerra.TabIndex = 8;
            btnCerra.Text = "Cerrar";
            btnCerra.UseVisualStyleBackColor = false;
            btnCerra.Click += btnCerra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCerra);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(TB_Prompt);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private TextBox TB_Prompt;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnCerra;
    }
}
