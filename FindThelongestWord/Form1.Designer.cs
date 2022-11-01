namespace FindThelongestWord
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.ChooseBox = new System.Windows.Forms.ListBox();
            this.buttonLongest = new System.Windows.Forms.Button();
            this.kuerzte = new System.Windows.Forms.Button();
            this.ChooseText = new System.Windows.Forms.Label();
            this.saveFileDialogTextfile = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(206, 110);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(410, 89);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Tag = "";
            this.textBoxInput.Text = "Geben Sie ihren Text hier ein...";
            this.textBoxInput.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // TextTitle
            // 
            this.TextTitle.AutoSize = true;
            this.TextTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextTitle.Location = new System.Drawing.Point(195, 67);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(432, 25);
            this.TextTitle.TabIndex = 1;
            this.TextTitle.Text = "Suche nach dem längsten oder kürzesten Wort.";
            // 
            // filterButton
            // 
            this.filterButton.AccessibleDescription = "";
            this.filterButton.Location = new System.Drawing.Point(365, 214);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(82, 26);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Suchen";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ChooseBox
            // 
            this.ChooseBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChooseBox.FormattingEnabled = true;
            this.ChooseBox.ItemHeight = 15;
            this.ChooseBox.Location = new System.Drawing.Point(206, 257);
            this.ChooseBox.Name = "ChooseBox";
            this.ChooseBox.Size = new System.Drawing.Size(410, 79);
            this.ChooseBox.TabIndex = 3;
            this.ChooseBox.Visible = false;
            // 
            // buttonLongest
            // 
            this.buttonLongest.Location = new System.Drawing.Point(235, 301);
            this.buttonLongest.Name = "buttonLongest";
            this.buttonLongest.Size = new System.Drawing.Size(147, 23);
            this.buttonLongest.TabIndex = 4;
            this.buttonLongest.Text = "Längste Wörter";
            this.buttonLongest.UseVisualStyleBackColor = true;
            this.buttonLongest.Visible = false;
            this.buttonLongest.Click += new System.EventHandler(this.buttonLongest_Click);
            // 
            // kuerzte
            // 
            this.kuerzte.Location = new System.Drawing.Point(411, 301);
            this.kuerzte.Name = "kuerzte";
            this.kuerzte.Size = new System.Drawing.Size(159, 23);
            this.kuerzte.TabIndex = 5;
            this.kuerzte.Text = "Kürzten Wörter";
            this.kuerzte.UseVisualStyleBackColor = true;
            this.kuerzte.Visible = false;
            this.kuerzte.Click += new System.EventHandler(this.kuerzte_Click);
            // 
            // ChooseText
            // 
            this.ChooseText.AutoSize = true;
            this.ChooseText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChooseText.Location = new System.Drawing.Point(365, 272);
            this.ChooseText.Name = "ChooseText";
            this.ChooseText.Size = new System.Drawing.Size(67, 15);
            this.ChooseText.TabIndex = 6;
            this.ChooseText.Text = "Wähle aus..";
            this.ChooseText.Visible = false;
            // 
            // saveFileDialogTextfile
            // 
            this.saveFileDialogTextfile.Filter = "Text files (*.txt)|*.txt";
            this.saveFileDialogTextfile.Title = "Save an Text file";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(365, 359);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ChooseText);
            this.Controls.Add(this.kuerzte);
            this.Controls.Add(this.buttonLongest);
            this.Controls.Add(this.ChooseBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.TextTitle);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxInput;
        private Label TextTitle;
        private Button filterButton;
        private ListBox ChooseBox;
        private Button buttonLongest;
        private Button kuerzte;
        private Label ChooseText;
        private SaveFileDialog saveFileDialogTextfile;
        private Button buttonSave;
    }
}