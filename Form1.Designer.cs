namespace Countries
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
            splitContainer1 = new SplitContainer();
            textInputLabel = new Label();
            comboBoxLabel = new Label();
            emptyComboBoxLabel = new Label();
            wrongInputLabel = new Label();
            confirmButton = new Button();
            nOfCountriesTextBox = new TextBox();
            continentComboBox = new ComboBox();
            noInformationLabel = new Label();
            pendingLabel = new Label();
            countriesTreeView = new TreeView();
            queryBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textInputLabel);
            splitContainer1.Panel1.Controls.Add(comboBoxLabel);
            splitContainer1.Panel1.Controls.Add(emptyComboBoxLabel);
            splitContainer1.Panel1.Controls.Add(wrongInputLabel);
            splitContainer1.Panel1.Controls.Add(confirmButton);
            splitContainer1.Panel1.Controls.Add(nOfCountriesTextBox);
            splitContainer1.Panel1.Controls.Add(continentComboBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(noInformationLabel);
            splitContainer1.Panel2.Controls.Add(pendingLabel);
            splitContainer1.Panel2.Controls.Add(countriesTreeView);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // textInputLabel
            // 
            textInputLabel.AutoSize = true;
            textInputLabel.Location = new Point(52, 171);
            textInputLabel.Name = "textInputLabel";
            textInputLabel.Size = new Size(154, 15);
            textInputLabel.TabIndex = 6;
            textInputLabel.Text = "Number of countries (2-10):";
            // 
            // comboBoxLabel
            // 
            comboBoxLabel.AutoSize = true;
            comboBoxLabel.Location = new Point(52, 49);
            comboBoxLabel.Name = "comboBoxLabel";
            comboBoxLabel.Size = new Size(63, 15);
            comboBoxLabel.TabIndex = 5;
            comboBoxLabel.Text = "Continent:";
            // 
            // emptyComboBoxLabel
            // 
            emptyComboBoxLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emptyComboBoxLabel.AutoSize = true;
            emptyComboBoxLabel.ForeColor = Color.Red;
            emptyComboBoxLabel.Location = new Point(80, 93);
            emptyComboBoxLabel.Name = "emptyComboBoxLabel";
            emptyComboBoxLabel.Size = new Size(110, 15);
            emptyComboBoxLabel.TabIndex = 4;
            emptyComboBoxLabel.Text = "Choose a continent";
            emptyComboBoxLabel.Visible = false;
            // 
            // wrongInputLabel
            // 
            wrongInputLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wrongInputLabel.AutoSize = true;
            wrongInputLabel.ForeColor = Color.Red;
            wrongInputLabel.Location = new Point(80, 215);
            wrongInputLabel.Name = "wrongInputLabel";
            wrongInputLabel.Size = new Size(116, 15);
            wrongInputLabel.TabIndex = 3;
            wrongInputLabel.Text = "Wrong input format!";
            wrongInputLabel.Visible = false;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(52, 297);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(165, 23);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += Confirm;
            // 
            // nOfCountriesTextBox
            // 
            nOfCountriesTextBox.Location = new Point(52, 189);
            nOfCountriesTextBox.Name = "nOfCountriesTextBox";
            nOfCountriesTextBox.Size = new Size(165, 23);
            nOfCountriesTextBox.TabIndex = 1;
            // 
            // continentComboBox
            // 
            continentComboBox.FormattingEnabled = true;
            continentComboBox.Location = new Point(52, 67);
            continentComboBox.Name = "continentComboBox";
            continentComboBox.Size = new Size(165, 23);
            continentComboBox.TabIndex = 0;
            // 
            // noInformationLabel
            // 
            noInformationLabel.AutoSize = true;
            noInformationLabel.BackColor = SystemColors.Window;
            noInformationLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            noInformationLabel.Location = new Point(93, 45);
            noInformationLabel.Name = "noInformationLabel";
            noInformationLabel.Size = new Size(340, 45);
            noInformationLabel.TabIndex = 2;
            noInformationLabel.Text = "No information found!";
            noInformationLabel.Visible = false;
            // 
            // pendingLabel
            // 
            pendingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pendingLabel.AutoSize = true;
            pendingLabel.BackColor = SystemColors.Window;
            pendingLabel.Font = new Font("Segoe UI", 52F, FontStyle.Regular, GraphicsUnit.Point);
            pendingLabel.Location = new Point(96, 153);
            pendingLabel.Name = "pendingLabel";
            pendingLabel.Size = new Size(337, 93);
            pendingLabel.TabIndex = 1;
            pendingLabel.Text = "Pending...";
            pendingLabel.Visible = false;
            // 
            // countriesTreeView
            // 
            countriesTreeView.Dock = DockStyle.Fill;
            countriesTreeView.Location = new Point(0, 0);
            countriesTreeView.Name = "countriesTreeView";
            countriesTreeView.Size = new Size(530, 450);
            countriesTreeView.TabIndex = 0;
            // 
            // queryBackgroundWorker
            // 
            queryBackgroundWorker.DoWork += PerformQuery;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button confirmButton;
        private TextBox nOfCountriesTextBox;
        private ComboBox continentComboBox;
        private TreeView countriesTreeView;
        private Label wrongInputLabel;
        private Label emptyComboBoxLabel;
        private Label textInputLabel;
        private Label comboBoxLabel;
        private System.ComponentModel.BackgroundWorker queryBackgroundWorker;
        private Label pendingLabel;
        private Label noInformationLabel;
    }
}