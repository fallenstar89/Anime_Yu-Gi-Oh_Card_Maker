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
            this.Effect = new System.Windows.Forms.Button();
            this.Trap = new System.Windows.Forms.Button();
            this.Magic = new System.Windows.Forms.Button();
            this.NormalMonster = new System.Windows.Forms.Button();
            this.Ritual = new System.Windows.Forms.Button();
            this.Synchro = new System.Windows.Forms.Button();
            this.Token = new System.Windows.Forms.Button();
            this.Fusion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.DuelistKingdomCard = new System.Windows.Forms.Button();
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
            this.LegendaryDragon.Click += new System.EventHandler(this.LegendaryDragon_Click);
            // 
            // Effect
            // 
            this.Effect.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Effect__Custom_;
            this.Effect.Cursor = System.Windows.Forms.Cursors.Default;
            this.Effect.Location = new System.Drawing.Point(579, 91);
            this.Effect.Name = "Effect";
            this.Effect.Size = new System.Drawing.Size(71, 104);
            this.Effect.TabIndex = 24;
            this.Effect.UseVisualStyleBackColor = true;
            this.Effect.Click += new System.EventHandler(this.Effect_Click);
            // 
            // Trap
            // 
            this.Trap.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Trap__Custom_;
            this.Trap.Cursor = System.Windows.Forms.Cursors.Default;
            this.Trap.Location = new System.Drawing.Point(656, 91);
            this.Trap.Name = "Trap";
            this.Trap.Size = new System.Drawing.Size(71, 104);
            this.Trap.TabIndex = 23;
            this.Trap.UseVisualStyleBackColor = true;
            this.Trap.Click += new System.EventHandler(this.Trap_Click);
            // 
            // Magic
            // 
            this.Magic.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Magic__Custom_;
            this.Magic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Magic.Location = new System.Drawing.Point(310, 201);
            this.Magic.Name = "Magic";
            this.Magic.Size = new System.Drawing.Size(71, 104);
            this.Magic.TabIndex = 22;
            this.Magic.UseVisualStyleBackColor = true;
            this.Magic.Click += new System.EventHandler(this.Magic_Click);
            // 
            // NormalMonster
            // 
            this.NormalMonster.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Normal_Monster__Custom_;
            this.NormalMonster.Cursor = System.Windows.Forms.Cursors.Default;
            this.NormalMonster.Location = new System.Drawing.Point(402, 201);
            this.NormalMonster.Name = "NormalMonster";
            this.NormalMonster.Size = new System.Drawing.Size(71, 104);
            this.NormalMonster.TabIndex = 21;
            this.NormalMonster.UseVisualStyleBackColor = true;
            this.NormalMonster.Click += new System.EventHandler(this.NormalMonster_Click);
            // 
            // Ritual
            // 
            this.Ritual.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Ritual__Custom_;
            this.Ritual.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ritual.Location = new System.Drawing.Point(489, 201);
            this.Ritual.Name = "Ritual";
            this.Ritual.Size = new System.Drawing.Size(71, 104);
            this.Ritual.TabIndex = 20;
            this.Ritual.UseVisualStyleBackColor = true;
            this.Ritual.Click += new System.EventHandler(this.Ritual_Click);
            // 
            // Synchro
            // 
            this.Synchro.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Synchro__Custom_;
            this.Synchro.Cursor = System.Windows.Forms.Cursors.Default;
            this.Synchro.Location = new System.Drawing.Point(579, 201);
            this.Synchro.Name = "Synchro";
            this.Synchro.Size = new System.Drawing.Size(71, 104);
            this.Synchro.TabIndex = 19;
            this.Synchro.UseVisualStyleBackColor = true;
            this.Synchro.Click += new System.EventHandler(this.Synchro_Click);
            // 
            // Token
            // 
            this.Token.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Token__Custom_;
            this.Token.Cursor = System.Windows.Forms.Cursors.Default;
            this.Token.Location = new System.Drawing.Point(656, 201);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(71, 104);
            this.Token.TabIndex = 18;
            this.Token.UseVisualStyleBackColor = true;
            this.Token.Click += new System.EventHandler(this.Token_Click);
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
            // DuelistKingdomCard
            // 
            this.DuelistKingdomCard.BackgroundImage = global::Anime_Yu_Gi_Oh_Card_Maker.Properties.Resources.Duelist_Kingdom_Card__Custom_;
            this.DuelistKingdomCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.DuelistKingdomCard.Location = new System.Drawing.Point(489, 91);
            this.DuelistKingdomCard.Name = "DuelistKingdomCard";
            this.DuelistKingdomCard.Size = new System.Drawing.Size(71, 104);
            this.DuelistKingdomCard.TabIndex = 30;
            this.DuelistKingdomCard.UseVisualStyleBackColor = true;
            this.DuelistKingdomCard.Click += new System.EventHandler(this.DuelistKingdomCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 395);
            this.Controls.Add(this.DuelistKingdomCard);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LegendaryDragon);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.Trap);
            this.Controls.Add(this.Magic);
            this.Controls.Add(this.NormalMonster);
            this.Controls.Add(this.Ritual);
            this.Controls.Add(this.Synchro);
            this.Controls.Add(this.Token);
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
        private System.Windows.Forms.Button Token;
        private System.Windows.Forms.Button Synchro;
        private System.Windows.Forms.Button Ritual;
        private System.Windows.Forms.Button NormalMonster;
        private System.Windows.Forms.Button Magic;
        private System.Windows.Forms.Button Trap;
        private System.Windows.Forms.Button Effect;
        private System.Windows.Forms.Button LegendaryDragon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.Button DuelistKingdomCard;



    }
}

