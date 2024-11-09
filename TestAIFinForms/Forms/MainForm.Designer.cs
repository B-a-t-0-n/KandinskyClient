namespace TestAIFinForms
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
            panelRight = new Panel();
            panel2 = new Panel();
            richTextBoxNegativePromt = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            richTextBoxPromt = new RichTextBox();
            labelPromt = new Label();
            panelSize = new Panel();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            panelStyle = new Panel();
            comboBoxStyles = new ComboBox();
            labelStyle = new Label();
            panelModel = new Panel();
            comboBoxModels = new ComboBox();
            labelModels = new Label();
            buttonGenerate = new Button();
            panel3 = new Panel();
            pictureBoxGenImage = new PictureBox();
            panel4 = new Panel();
            panelRight.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelSize.SuspendLayout();
            panelStyle.SuspendLayout();
            panelModel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenImage).BeginInit();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(54, 54, 54);
            panelRight.Controls.Add(panel2);
            panelRight.Controls.Add(panel1);
            panelRight.Controls.Add(panelSize);
            panelRight.Controls.Add(panelStyle);
            panelRight.Controls.Add(panelModel);
            panelRight.Controls.Add(buttonGenerate);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(997, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(196, 828);
            panelRight.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBoxNegativePromt);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 557);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 204);
            panel2.TabIndex = 5;
            // 
            // richTextBoxNegativePromt
            // 
            richTextBoxNegativePromt.BackColor = Color.FromArgb(74, 74, 74);
            richTextBoxNegativePromt.BorderStyle = BorderStyle.None;
            richTextBoxNegativePromt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxNegativePromt.ForeColor = Color.White;
            richTextBoxNegativePromt.Location = new Point(14, 47);
            richTextBoxNegativePromt.Name = "richTextBoxNegativePromt";
            richTextBoxNegativePromt.Size = new Size(169, 141);
            richTextBoxNegativePromt.TabIndex = 4;
            richTextBoxNegativePromt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 3;
            label1.Text = "Негативный промт";
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBoxPromt);
            panel1.Controls.Add(labelPromt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 204);
            panel1.TabIndex = 4;
            // 
            // richTextBoxPromt
            // 
            richTextBoxPromt.BackColor = Color.FromArgb(74, 74, 74);
            richTextBoxPromt.BorderStyle = BorderStyle.None;
            richTextBoxPromt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxPromt.ForeColor = Color.White;
            richTextBoxPromt.Location = new Point(14, 47);
            richTextBoxPromt.Name = "richTextBoxPromt";
            richTextBoxPromt.Size = new Size(169, 141);
            richTextBoxPromt.TabIndex = 4;
            richTextBoxPromt.Text = "";
            // 
            // labelPromt
            // 
            labelPromt.AutoSize = true;
            labelPromt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPromt.ForeColor = Color.White;
            labelPromt.Location = new Point(13, 9);
            labelPromt.Name = "labelPromt";
            labelPromt.Size = new Size(69, 25);
            labelPromt.TabIndex = 3;
            labelPromt.Text = "Промт";
            // 
            // panelSize
            // 
            panelSize.Controls.Add(labelWeight);
            panelSize.Controls.Add(textBoxWeight);
            panelSize.Controls.Add(labelHeight);
            panelSize.Controls.Add(textBoxHeight);
            panelSize.Dock = DockStyle.Top;
            panelSize.Location = new Point(0, 190);
            panelSize.Name = "panelSize";
            panelSize.Size = new Size(196, 163);
            panelSize.TabIndex = 3;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.White;
            labelWeight.Location = new Point(14, 77);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(84, 25);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Ширина";
            // 
            // textBoxWeight
            // 
            textBoxWeight.BackColor = Color.FromArgb(74, 74, 74);
            textBoxWeight.BorderStyle = BorderStyle.None;
            textBoxWeight.Cursor = Cursors.IBeam;
            textBoxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxWeight.ForeColor = Color.White;
            textBoxWeight.Location = new Point(13, 115);
            textBoxWeight.MaxLength = 10;
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(170, 22);
            textBoxWeight.TabIndex = 6;
            textBoxWeight.KeyPress += TextBoxNum_KeyPress;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHeight.ForeColor = Color.White;
            labelHeight.Location = new Point(14, 15);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(74, 25);
            labelHeight.TabIndex = 5;
            labelHeight.Text = "Высота";
            // 
            // textBoxHeight
            // 
            textBoxHeight.BackColor = Color.FromArgb(74, 74, 74);
            textBoxHeight.BorderStyle = BorderStyle.None;
            textBoxHeight.Cursor = Cursors.IBeam;
            textBoxHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHeight.ForeColor = Color.White;
            textBoxHeight.Location = new Point(14, 52);
            textBoxHeight.MaxLength = 10;
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(170, 22);
            textBoxHeight.TabIndex = 4;
            textBoxHeight.KeyPress += TextBoxNum_KeyPress;
            // 
            // panelStyle
            // 
            panelStyle.Controls.Add(comboBoxStyles);
            panelStyle.Controls.Add(labelStyle);
            panelStyle.Dock = DockStyle.Top;
            panelStyle.Location = new Point(0, 95);
            panelStyle.Name = "panelStyle";
            panelStyle.Size = new Size(196, 95);
            panelStyle.TabIndex = 2;
            // 
            // comboBoxStyles
            // 
            comboBoxStyles.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxStyles.Cursor = Cursors.Hand;
            comboBoxStyles.FlatStyle = FlatStyle.Flat;
            comboBoxStyles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStyles.ForeColor = Color.White;
            comboBoxStyles.FormattingEnabled = true;
            comboBoxStyles.Location = new Point(13, 47);
            comboBoxStyles.Name = "comboBoxStyles";
            comboBoxStyles.Size = new Size(170, 29);
            comboBoxStyles.TabIndex = 4;
            comboBoxStyles.SelectedIndexChanged += ComboBoxStyles_SelectedIndexChanged;
            // 
            // labelStyle
            // 
            labelStyle.AutoSize = true;
            labelStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStyle.ForeColor = Color.White;
            labelStyle.Location = new Point(13, 9);
            labelStyle.Name = "labelStyle";
            labelStyle.Size = new Size(63, 25);
            labelStyle.TabIndex = 3;
            labelStyle.Text = "Стиль";
            // 
            // panelModel
            // 
            panelModel.Controls.Add(comboBoxModels);
            panelModel.Controls.Add(labelModels);
            panelModel.Dock = DockStyle.Top;
            panelModel.Location = new Point(0, 0);
            panelModel.Name = "panelModel";
            panelModel.Size = new Size(196, 95);
            panelModel.TabIndex = 1;
            // 
            // comboBoxModels
            // 
            comboBoxModels.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxModels.Cursor = Cursors.Hand;
            comboBoxModels.FlatStyle = FlatStyle.Flat;
            comboBoxModels.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxModels.ForeColor = Color.White;
            comboBoxModels.FormattingEnabled = true;
            comboBoxModels.Location = new Point(13, 47);
            comboBoxModels.Name = "comboBoxModels";
            comboBoxModels.Size = new Size(170, 29);
            comboBoxModels.TabIndex = 4;
            // 
            // labelModels
            // 
            labelModels.AutoSize = true;
            labelModels.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelModels.ForeColor = Color.White;
            labelModels.Location = new Point(13, 9);
            labelModels.Name = "labelModels";
            labelModels.Size = new Size(80, 25);
            labelModels.TabIndex = 3;
            labelModels.Text = "Модель";
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.SlateBlue;
            buttonGenerate.Cursor = Cursors.Hand;
            buttonGenerate.Dock = DockStyle.Bottom;
            buttonGenerate.FlatAppearance.BorderSize = 0;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(0, 759);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(196, 69);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "сгенерировать";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBoxGenImage);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 828);
            panel3.TabIndex = 2;
            // 
            // pictureBoxGenImage
            // 
            pictureBoxGenImage.Dock = DockStyle.Fill;
            pictureBoxGenImage.Location = new Point(0, 0);
            pictureBoxGenImage.Name = "pictureBoxGenImage";
            pictureBoxGenImage.Size = new Size(997, 759);
            pictureBoxGenImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGenImage.TabIndex = 1;
            pictureBoxGenImage.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(54, 54, 54);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 759);
            panel4.Name = "panel4";
            panel4.Size = new Size(997, 69);
            panel4.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1193, 828);
            Controls.Add(panel3);
            Controls.Add(panelRight);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kandinsky";
            panelRight.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSize.ResumeLayout(false);
            panelSize.PerformLayout();
            panelStyle.ResumeLayout(false);
            panelStyle.PerformLayout();
            panelModel.ResumeLayout(false);
            panelModel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRight;
        private Button buttonGenerate;
        private Panel panelStyle;
        private ComboBox comboBoxStyles;
        private Label labelStyle;
        private Panel panelModel;
        private ComboBox comboBoxModels;
        private Label labelModels;
        private Panel panelSize;
        private TextBox textBoxHeight;
        private Label labelHeight;
        private Label labelWeight;
        private TextBox textBoxWeight;
        private Panel panel1;
        private RichTextBox richTextBoxPromt;
        private Label labelPromt;
        private Panel panel2;
        private RichTextBox richTextBoxNegativePromt;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBoxGenImage;
        private Panel panel4;
    }
}
