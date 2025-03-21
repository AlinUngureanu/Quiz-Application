namespace Quiz_Application
{
    partial class Form_ChooseDomain
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
            this.label_urare = new System.Windows.Forms.Label();
            this.label_list = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_choose = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_urare
            // 
            this.label_urare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_urare.AutoSize = true;
            this.label_urare.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_urare.Location = new System.Drawing.Point(212, 46);
            this.label_urare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_urare.Name = "label_urare";
            this.label_urare.Size = new System.Drawing.Size(100, 14);
            this.label_urare.TabIndex = 0;
            this.label_urare.Text = "Salutare username";
            // 
            // label_list
            // 
            this.label_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_list.AutoSize = true;
            this.label_list.Location = new System.Drawing.Point(84, 92);
            this.label_list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(84, 13);
            this.label_list.TabIndex = 1;
            this.label_list.Text = "Alegeți domeniul";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Arta",
            "Istorie",
            "Sport",
            "Geografie",
            "Stiinta"});
            this.listBox1.Location = new System.Drawing.Point(82, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 121);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(345, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_choose
            // 
            this.button_choose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_choose.Location = new System.Drawing.Point(241, 253);
            this.button_choose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(56, 23);
            this.button_choose.TabIndex = 4;
            this.button_choose.Text = "Alege";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_exit.Location = new System.Drawing.Point(241, 305);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(56, 21);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Ieșire";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form_ChooseDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_list);
            this.Controls.Add(this.label_urare);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ChooseDomain";
            this.Text = "Domenii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_urare;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.Button button_exit;
    }
}