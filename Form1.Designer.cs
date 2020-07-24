namespace LeagueBuildHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGarena = new System.Windows.Forms.Button();
            this.btnEuw = new System.Windows.Forms.Button();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.ComboBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnCounter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSummoner = new System.Windows.Forms.TextBox();
            this.pContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LeagueBuildHelper.Properties.Resources.text;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGarena);
            this.groupBox1.Controls.Add(this.btnEuw);
            this.groupBox1.Controls.Add(this.txtPing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(349, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PING";
            // 
            // btnGarena
            // 
            this.btnGarena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGarena.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGarena.Location = new System.Drawing.Point(100, 19);
            this.btnGarena.Name = "btnGarena";
            this.btnGarena.Size = new System.Drawing.Size(82, 23);
            this.btnGarena.TabIndex = 8;
            this.btnGarena.Text = "GArena";
            this.btnGarena.UseVisualStyleBackColor = false;
            this.btnGarena.Click += new System.EventHandler(this.btnGarena_Click);
            // 
            // btnEuw
            // 
            this.btnEuw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEuw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEuw.Location = new System.Drawing.Point(51, 19);
            this.btnEuw.Name = "btnEuw";
            this.btnEuw.Size = new System.Drawing.Size(43, 23);
            this.btnEuw.TabIndex = 7;
            this.btnEuw.Text = "EUW";
            this.btnEuw.UseVisualStyleBackColor = false;
            this.btnEuw.Click += new System.EventHandler(this.btnEuw_Click);
            // 
            // txtPing
            // 
            this.txtPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPing.Location = new System.Drawing.Point(6, 20);
            this.txtPing.Name = "txtPing";
            this.txtPing.ReadOnly = true;
            this.txtPing.Size = new System.Drawing.Size(39, 23);
            this.txtPing.TabIndex = 2;
            this.txtPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUrl
            // 
            this.txtUrl.FormattingEnabled = true;
            this.txtUrl.Items.AddRange(new object[] {
            "aatrox",
            "ahri",
            "akali",
            "alistar",
            "amumu",
            "anivia",
            "annie",
            "aphelios",
            "ashe",
            "aurelionsol",
            "azir",
            "bard",
            "blitzcrank",
            "brand",
            "braum",
            "caitlyn",
            "camille",
            "cassiopeia",
            "chogath",
            "corki",
            "darius",
            "diana",
            "dr.mundo",
            "draven",
            "ekko",
            "elise",
            "evelynn",
            "ezreal",
            "fiddlesticks",
            "fiora",
            "fizz",
            "galio",
            "gangplank",
            "garen",
            "gnar",
            "gragas",
            "graves",
            "hecarim",
            "heimerdinger",
            "illaoi",
            "irelia",
            "ivern",
            "janna",
            "jarvaniv",
            "jax",
            "jayce",
            "jhin",
            "jinx",
            "kaisa",
            "kalista",
            "karma",
            "karthus",
            "kassadin",
            "katarina",
            "kayle",
            "kayn",
            "kennen",
            "khazix",
            "kindred",
            "kled",
            "kogmaw",
            "leblanc",
            "leesin",
            "leona",
            "lillia",
            "lissandra",
            "lucian",
            "lulu",
            "lux",
            "malphite",
            "malzahar",
            "maokai",
            "masteryi",
            "missfortune",
            "mordekaiser",
            "morgana",
            "nami",
            "nasus",
            "nautilus",
            "neeko",
            "nidalee",
            "nocturne",
            "nunu",
            "olaf",
            "orianna",
            "ornn",
            "pantheon",
            "poppy",
            "pyke",
            "qiyana",
            "quinn",
            "rakan",
            "rammus",
            "reksai",
            "renekton",
            "rengar",
            "riven",
            "rumble",
            "ryze",
            "sejuani",
            "senna",
            "sett",
            "shaco",
            "shen",
            "shyvana",
            "singed",
            "sion",
            "sivir",
            "skarner",
            "sona",
            "soraka",
            "swain",
            "sylas",
            "syndra",
            "tahmkench",
            "taliyah",
            "talon",
            "taric",
            "teemo",
            "thresh",
            "tristana",
            "trundle",
            "tryndamere",
            "twistedfate",
            "twitch",
            "udyr",
            "urgot",
            "varus",
            "vayne",
            "veigar",
            "velkoz",
            "vi",
            "viktor",
            "vladimir",
            "volibear",
            "warwick",
            "wukong",
            "xayah",
            "xerath",
            "xinzhao",
            "yasuo",
            "yorick",
            "yuumi",
            "zac",
            "zed",
            "ziggs",
            "zilean",
            "zoe",
            "zyra"});
            this.txtUrl.Location = new System.Drawing.Point(12, 77);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(133, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(151, 77);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(93, 21);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Search &Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(250, 77);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(93, 21);
            this.btnCounter.TabIndex = 4;
            this.btnCounter.Text = "&Counterpick";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check &Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Summoner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSummoner
            // 
            this.txtSummoner.BackColor = System.Drawing.Color.White;
            this.txtSummoner.Location = new System.Drawing.Point(12, 104);
            this.txtSummoner.Name = "txtSummoner";
            this.txtSummoner.Size = new System.Drawing.Size(133, 22);
            this.txtSummoner.TabIndex = 7;
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pContainer.Location = new System.Drawing.Point(0, 131);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(548, 592);
            this.pContainer.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(549, 725);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.txtSummoner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends Build Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtUrl;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.Button btnGarena;
        private System.Windows.Forms.Button btnEuw;
        private System.Windows.Forms.TextBox txtSummoner;
        private System.Windows.Forms.Panel pContainer;
    }
}

