namespace Anime_Yu_Gi_Oh_Card_Maker
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ATKt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DEFt = new System.Windows.Forms.TextBox();
            this.Element = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LegendaryDragon = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Fusion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ATKt
            // 
            this.ATKt.Location = new System.Drawing.Point(35, 51);
            this.ATKt.Name = "ATKt";
            this.ATKt.Size = new System.Drawing.Size(100, 20);
            this.ATKt.TabIndex = 2;
            this.ATKt.Text = ".5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Defense Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attack Level";
            // 
            // DEFt
            // 
            this.DEFt.Location = new System.Drawing.Point(173, 51);
            this.DEFt.Name = "DEFt";
            this.DEFt.Size = new System.Drawing.Size(100, 20);
            this.DEFt.TabIndex = 5;
            this.DEFt.Text = "100";
            // 
            // Element
            // 
            this.Element.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Element.FormattingEnabled = true;
            this.Element.Items.AddRange(new object[] {
            "Water",
            "Fire",
            "Earth",
            "Divine",
            "Wind",
            "Dark",
            "Light"});
            this.Element.Location = new System.Drawing.Point(310, 51);
            this.Element.Name = "Element";
            this.Element.Size = new System.Drawing.Size(121, 21);
            this.Element.TabIndex = 15;
            this.Element.SelectedIndexChanged += new System.EventHandler(this.Element_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Element";
            // 
            // LegendaryDragon
            // 
            this.LegendaryDragon.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Legendary_Dragon__Custom_;
            this.LegendaryDragon.Cursor = System.Windows.Forms.Cursors.Default;
            this.LegendaryDragon.Location = new System.Drawing.Point(402, 91);
            this.LegendaryDragon.Name = "LegendaryDragon";
            this.LegendaryDragon.Size = new System.Drawing.Size(71, 104);
            this.LegendaryDragon.TabIndex = 26;
            this.LegendaryDragon.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Duelist_Kingdom_Card__Custom_;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Location = new System.Drawing.Point(489, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 104);
            this.button9.TabIndex = 25;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Effect__Custom_;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.Location = new System.Drawing.Point(579, 91);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 104);
            this.button8.TabIndex = 24;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Trap__Custom_;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.Location = new System.Drawing.Point(656, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 104);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Magic__Custom_;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Location = new System.Drawing.Point(310, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 104);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Normal_Monster__Custom_;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Location = new System.Drawing.Point(402, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 104);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Ritual__Custom_;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(489, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 104);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Synchro__Custom_;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(579, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 104);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Token__Custom_;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(656, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 104);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Fusion
            // 
            this.Fusion.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Fusion__69x100_;
            this.Fusion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fusion.Location = new System.Drawing.Point(310, 91);
            this.Fusion.Name = "Fusion";
            this.Fusion.Size = new System.Drawing.Size(71, 104);
            this.Fusion.TabIndex = 17;
            this.Fusion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Level";
            // 
            // Level
            // 
            this.Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Level.FormattingEnabled = true;
            this.Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Level.Location = new System.Drawing.Point(507, 49);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(121, 21);
            this.Level.TabIndex = 29;
            this.Level.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 395);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LegendaryDragon);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fusion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Element);
            this.Controls.Add(this.DEFt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ATKt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Attack Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ATKt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DEFt;
        private System.Windows.Forms.ComboBox Element;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Fusion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button LegendaryDragon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Level;



    }
}

