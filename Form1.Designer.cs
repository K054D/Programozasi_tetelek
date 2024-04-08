namespace Programozási_tételek
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elemiTételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorozatszamitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eldöntésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIválasztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineárisKeresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megszámolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumkiválasztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összetettTételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiválogatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szétválogatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metszetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összefuttatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyszerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buborékosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javítottBuborékosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumkiválasztásosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javítottBeillesztésesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIneárisKeresésrendezettSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logaritmikusKeresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelKod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelLenyeg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelFeladat = new System.Windows.Forms.Label();
            this.TBInput1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FajlInput = new System.Windows.Forms.Button();
            this.TBInput2 = new System.Windows.Forms.TextBox();
            this.BtnEredmeny = new System.Windows.Forms.Button();
            this.LabelEredmeny = new System.Windows.Forms.Label();
            this.takaro = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnMentes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.takaro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elemiTételekToolStripMenuItem,
            this.összetettTételekToolStripMenuItem,
            this.rendezésekToolStripMenuItem,
            this.keresésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elemiTételekToolStripMenuItem
            // 
            this.elemiTételekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorozatszamitasToolStripMenuItem,
            this.eldöntésToolStripMenuItem,
            this.kIválasztásToolStripMenuItem,
            this.lineárisKeresésToolStripMenuItem,
            this.megszámolásToolStripMenuItem,
            this.maximumkiválasztásToolStripMenuItem});
            this.elemiTételekToolStripMenuItem.Name = "elemiTételekToolStripMenuItem";
            this.elemiTételekToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.elemiTételekToolStripMenuItem.Text = "Elemi tételek";
            // 
            // sorozatszamitasToolStripMenuItem
            // 
            this.sorozatszamitasToolStripMenuItem.Name = "sorozatszamitasToolStripMenuItem";
            this.sorozatszamitasToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.sorozatszamitasToolStripMenuItem.Text = "Sorozatszámítás";
            this.sorozatszamitasToolStripMenuItem.Click += new System.EventHandler(this.sorozatszamitasToolStripMenuItem_Click);
            // 
            // eldöntésToolStripMenuItem
            // 
            this.eldöntésToolStripMenuItem.Name = "eldöntésToolStripMenuItem";
            this.eldöntésToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.eldöntésToolStripMenuItem.Text = "Eldöntés";
            this.eldöntésToolStripMenuItem.Click += new System.EventHandler(this.eldöntésToolStripMenuItem_Click);
            // 
            // kIválasztásToolStripMenuItem
            // 
            this.kIválasztásToolStripMenuItem.Name = "kIválasztásToolStripMenuItem";
            this.kIválasztásToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.kIválasztásToolStripMenuItem.Text = "Kiválasztás";
            this.kIválasztásToolStripMenuItem.Click += new System.EventHandler(this.kIválasztásToolStripMenuItem_Click);
            // 
            // lineárisKeresésToolStripMenuItem
            // 
            this.lineárisKeresésToolStripMenuItem.Name = "lineárisKeresésToolStripMenuItem";
            this.lineárisKeresésToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.lineárisKeresésToolStripMenuItem.Text = "Lineáris keresés (rendezetlen adathalmazban)";
            this.lineárisKeresésToolStripMenuItem.Click += new System.EventHandler(this.lineárisKeresésToolStripMenuItem_Click);
            // 
            // megszámolásToolStripMenuItem
            // 
            this.megszámolásToolStripMenuItem.Name = "megszámolásToolStripMenuItem";
            this.megszámolásToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.megszámolásToolStripMenuItem.Text = "Megszámolás";
            this.megszámolásToolStripMenuItem.Click += new System.EventHandler(this.megszámolásToolStripMenuItem_Click);
            // 
            // maximumkiválasztásToolStripMenuItem
            // 
            this.maximumkiválasztásToolStripMenuItem.Name = "maximumkiválasztásToolStripMenuItem";
            this.maximumkiválasztásToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.maximumkiválasztásToolStripMenuItem.Text = "Maximumkiválasztás";
            this.maximumkiválasztásToolStripMenuItem.Click += new System.EventHandler(this.maximumkiválasztásToolStripMenuItem_Click);
            // 
            // összetettTételekToolStripMenuItem
            // 
            this.összetettTételekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.másolásToolStripMenuItem,
            this.kiválogatásToolStripMenuItem,
            this.szétválogatásToolStripMenuItem,
            this.metszetToolStripMenuItem,
            this.unióToolStripMenuItem,
            this.összefuttatásToolStripMenuItem});
            this.összetettTételekToolStripMenuItem.Name = "összetettTételekToolStripMenuItem";
            this.összetettTételekToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.összetettTételekToolStripMenuItem.Text = "Összetett tételek";
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.másolásToolStripMenuItem.Text = "Másolás";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // kiválogatásToolStripMenuItem
            // 
            this.kiválogatásToolStripMenuItem.Name = "kiválogatásToolStripMenuItem";
            this.kiválogatásToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.kiválogatásToolStripMenuItem.Text = "Kiválogatás";
            this.kiválogatásToolStripMenuItem.Click += new System.EventHandler(this.kiválogatásToolStripMenuItem_Click);
            // 
            // szétválogatásToolStripMenuItem
            // 
            this.szétválogatásToolStripMenuItem.Name = "szétválogatásToolStripMenuItem";
            this.szétválogatásToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.szétválogatásToolStripMenuItem.Text = "Szétválogatás";
            this.szétválogatásToolStripMenuItem.Click += new System.EventHandler(this.szétválogatásToolStripMenuItem_Click);
            // 
            // metszetToolStripMenuItem
            // 
            this.metszetToolStripMenuItem.Name = "metszetToolStripMenuItem";
            this.metszetToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.metszetToolStripMenuItem.Text = "Metszet";
            this.metszetToolStripMenuItem.Click += new System.EventHandler(this.metszetToolStripMenuItem_Click);
            // 
            // unióToolStripMenuItem
            // 
            this.unióToolStripMenuItem.Name = "unióToolStripMenuItem";
            this.unióToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.unióToolStripMenuItem.Text = "Unió";
            this.unióToolStripMenuItem.Click += new System.EventHandler(this.unióToolStripMenuItem_Click);
            // 
            // összefuttatásToolStripMenuItem
            // 
            this.összefuttatásToolStripMenuItem.Name = "összefuttatásToolStripMenuItem";
            this.összefuttatásToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.összefuttatásToolStripMenuItem.Text = "Összefuttatás";
            this.összefuttatásToolStripMenuItem.Click += new System.EventHandler(this.összefuttatásToolStripMenuItem_Click);
            // 
            // rendezésekToolStripMenuItem
            // 
            this.rendezésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egyszerToolStripMenuItem,
            this.buborékosToolStripMenuItem,
            this.javítottBuborékosToolStripMenuItem,
            this.minimumkiválasztásosToolStripMenuItem,
            this.javítottBeillesztésesToolStripMenuItem});
            this.rendezésekToolStripMenuItem.Name = "rendezésekToolStripMenuItem";
            this.rendezésekToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.rendezésekToolStripMenuItem.Text = "Rendezések";
            // 
            // egyszerToolStripMenuItem
            // 
            this.egyszerToolStripMenuItem.Name = "egyszerToolStripMenuItem";
            this.egyszerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.egyszerToolStripMenuItem.Text = "Egyszerű cserés";
            this.egyszerToolStripMenuItem.Click += new System.EventHandler(this.egyszerToolStripMenuItem_Click);
            // 
            // buborékosToolStripMenuItem
            // 
            this.buborékosToolStripMenuItem.Name = "buborékosToolStripMenuItem";
            this.buborékosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.buborékosToolStripMenuItem.Text = "Buborékos";
            this.buborékosToolStripMenuItem.Click += new System.EventHandler(this.buborékosToolStripMenuItem_Click);
            // 
            // javítottBuborékosToolStripMenuItem
            // 
            this.javítottBuborékosToolStripMenuItem.Name = "javítottBuborékosToolStripMenuItem";
            this.javítottBuborékosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.javítottBuborékosToolStripMenuItem.Text = "Javított buborékos";
            this.javítottBuborékosToolStripMenuItem.Click += new System.EventHandler(this.javítottBuborékosToolStripMenuItem_Click);
            // 
            // minimumkiválasztásosToolStripMenuItem
            // 
            this.minimumkiválasztásosToolStripMenuItem.Name = "minimumkiválasztásosToolStripMenuItem";
            this.minimumkiválasztásosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.minimumkiválasztásosToolStripMenuItem.Text = "Minimumkiválasztásos";
            this.minimumkiválasztásosToolStripMenuItem.Click += new System.EventHandler(this.minimumkiválasztásosToolStripMenuItem_Click);
            // 
            // javítottBeillesztésesToolStripMenuItem
            // 
            this.javítottBeillesztésesToolStripMenuItem.Name = "javítottBeillesztésesToolStripMenuItem";
            this.javítottBeillesztésesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.javítottBeillesztésesToolStripMenuItem.Text = "Javított beillesztéses";
            this.javítottBeillesztésesToolStripMenuItem.Click += new System.EventHandler(this.javítottBeillesztésesToolStripMenuItem_Click);
            // 
            // keresésekToolStripMenuItem
            // 
            this.keresésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIneárisKeresésrendezettSorToolStripMenuItem,
            this.logaritmikusKeresésToolStripMenuItem});
            this.keresésekToolStripMenuItem.Name = "keresésekToolStripMenuItem";
            this.keresésekToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.keresésekToolStripMenuItem.Text = "Keresések";
            // 
            // lIneárisKeresésrendezettSorToolStripMenuItem
            // 
            this.lIneárisKeresésrendezettSorToolStripMenuItem.Name = "lIneárisKeresésrendezettSorToolStripMenuItem";
            this.lIneárisKeresésrendezettSorToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.lIneárisKeresésrendezettSorToolStripMenuItem.Text = "LIneáris keresés (rendezett adathalmazban";
            this.lIneárisKeresésrendezettSorToolStripMenuItem.Click += new System.EventHandler(this.lIneárisKeresésrendezettSorToolStripMenuItem_Click);
            // 
            // logaritmikusKeresésToolStripMenuItem
            // 
            this.logaritmikusKeresésToolStripMenuItem.Name = "logaritmikusKeresésToolStripMenuItem";
            this.logaritmikusKeresésToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.logaritmikusKeresésToolStripMenuItem.Text = "Logaritmikus keresés";
            this.logaritmikusKeresésToolStripMenuItem.Click += new System.EventHandler(this.logaritmikusKeresésToolStripMenuItem_Click);
            // 
            // LabelKod
            // 
            this.LabelKod.AutoSize = true;
            this.LabelKod.Location = new System.Drawing.Point(47, 182);
            this.LabelKod.Name = "LabelKod";
            this.LabelKod.Size = new System.Drawing.Size(0, 13);
            this.LabelKod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pszeudo kód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tétel lényege:";
            // 
            // LabelLenyeg
            // 
            this.LabelLenyeg.AutoSize = true;
            this.LabelLenyeg.Location = new System.Drawing.Point(47, 86);
            this.LabelLenyeg.MaximumSize = new System.Drawing.Size(250, 0);
            this.LabelLenyeg.Name = "LabelLenyeg";
            this.LabelLenyeg.Size = new System.Drawing.Size(0, 13);
            this.LabelLenyeg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mintafeladat:";
            // 
            // LabelFeladat
            // 
            this.LabelFeladat.AutoSize = true;
            this.LabelFeladat.Location = new System.Drawing.Point(356, 86);
            this.LabelFeladat.MaximumSize = new System.Drawing.Size(400, 0);
            this.LabelFeladat.Name = "LabelFeladat";
            this.LabelFeladat.Size = new System.Drawing.Size(0, 13);
            this.LabelFeladat.TabIndex = 6;
            // 
            // TBInput1
            // 
            this.TBInput1.Location = new System.Drawing.Point(315, 182);
            this.TBInput1.Name = "TBInput1";
            this.TBInput1.Size = new System.Drawing.Size(160, 20);
            this.TBInput1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FajlInput
            // 
            this.FajlInput.Location = new System.Drawing.Point(511, 182);
            this.FajlInput.Name = "FajlInput";
            this.FajlInput.Size = new System.Drawing.Size(121, 23);
            this.FajlInput.TabIndex = 3;
            this.FajlInput.Text = "Fájl kiválasztása";
            this.FajlInput.UseVisualStyleBackColor = true;
            this.FajlInput.Click += new System.EventHandler(this.FajlInput_Click);
            // 
            // TBInput2
            // 
            this.TBInput2.Location = new System.Drawing.Point(315, 220);
            this.TBInput2.Name = "TBInput2";
            this.TBInput2.Size = new System.Drawing.Size(160, 20);
            this.TBInput2.TabIndex = 2;
            // 
            // BtnEredmeny
            // 
            this.BtnEredmeny.Location = new System.Drawing.Point(315, 263);
            this.BtnEredmeny.Name = "BtnEredmeny";
            this.BtnEredmeny.Size = new System.Drawing.Size(75, 23);
            this.BtnEredmeny.TabIndex = 4;
            this.BtnEredmeny.Text = "Eredmény";
            this.BtnEredmeny.UseVisualStyleBackColor = true;
            // 
            // LabelEredmeny
            // 
            this.LabelEredmeny.AutoSize = true;
            this.LabelEredmeny.Location = new System.Drawing.Point(312, 319);
            this.LabelEredmeny.Name = "LabelEredmeny";
            this.LabelEredmeny.Size = new System.Drawing.Size(0, 13);
            this.LabelEredmeny.TabIndex = 11;
            // 
            // takaro
            // 
            this.takaro.Controls.Add(this.label5);
            this.takaro.Controls.Add(this.label4);
            this.takaro.Location = new System.Drawing.Point(0, 27);
            this.takaro.Name = "takaro";
            this.takaro.Size = new System.Drawing.Size(800, 424);
            this.takaro.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(246, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Válasszon a menüpontok közül!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÜDVÖZÖLJÜK!";
            // 
            // BtnMentes
            // 
            this.BtnMentes.Location = new System.Drawing.Point(315, 358);
            this.BtnMentes.Name = "BtnMentes";
            this.BtnMentes.Size = new System.Drawing.Size(145, 23);
            this.BtnMentes.TabIndex = 5;
            this.BtnMentes.Text = "Eredmény mentése fájlba";
            this.BtnMentes.UseVisualStyleBackColor = true;
            this.BtnMentes.Click += new System.EventHandler(this.BtnMentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMentes);
            this.Controls.Add(this.takaro);
            this.Controls.Add(this.LabelEredmeny);
            this.Controls.Add(this.BtnEredmeny);
            this.Controls.Add(this.TBInput2);
            this.Controls.Add(this.FajlInput);
            this.Controls.Add(this.TBInput1);
            this.Controls.Add(this.LabelFeladat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelLenyeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelKod);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ㅤ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.takaro.ResumeLayout(false);
            this.takaro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elemiTételekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összetettTételekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorozatszamitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eldöntésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIválasztásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineárisKeresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megszámolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumkiválasztásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiválogatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szétválogatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyszerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buborékosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javítottBuborékosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumkiválasztásosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javítottBeillesztésesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metszetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összefuttatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIneárisKeresésrendezettSorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logaritmikusKeresésToolStripMenuItem;
        private System.Windows.Forms.Label LabelKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelLenyeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelFeladat;
        private System.Windows.Forms.TextBox TBInput1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FajlInput;
        private System.Windows.Forms.TextBox TBInput2;
        private System.Windows.Forms.Button BtnEredmeny;
        private System.Windows.Forms.Label LabelEredmeny;
        private System.Windows.Forms.Panel takaro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnMentes;
    }
}

