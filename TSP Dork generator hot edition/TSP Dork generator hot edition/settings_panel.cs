using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using TSP_Dork_generator_hot_edition.My;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public class settings_panel : UserControl
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00009A9C File Offset: 0x00007C9C
		public settings_panel()
		{
			base.Load += this.settings_panel_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009ABC File Offset: 0x00007CBC
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009B0C File Offset: 0x00007D0C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new Label();
			this.English = new CheckBox();
			this.Deutch = new CheckBox();
			this.Spanish = new CheckBox();
			this.Italian = new CheckBox();
			this.Button2 = new Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new Font("Consolas", 9f);
			this.Label1.Location = new Point(27, 21);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(70, 14);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "Language:";
			this.English.AutoSize = true;
			this.English.Location = new Point(30, 43);
			this.English.Name = "English";
			this.English.Size = new Size(60, 17);
			this.English.TabIndex = 21;
			this.English.Text = "English";
			this.English.UseVisualStyleBackColor = true;
			this.Deutch.AutoSize = true;
			this.Deutch.Location = new Point(30, 66);
			this.Deutch.Name = "Deutch";
			this.Deutch.Size = new Size(61, 17);
			this.Deutch.TabIndex = 22;
			this.Deutch.Text = "Deutch";
			this.Deutch.UseVisualStyleBackColor = true;
			this.Spanish.AutoSize = true;
			this.Spanish.Location = new Point(30, 89);
			this.Spanish.Name = "Spanish";
			this.Spanish.Size = new Size(64, 17);
			this.Spanish.TabIndex = 23;
			this.Spanish.Text = "Spanish";
			this.Spanish.UseVisualStyleBackColor = true;
			this.Italian.AutoSize = true;
			this.Italian.Location = new Point(30, 112);
			this.Italian.Name = "Italian";
			this.Italian.Size = new Size(54, 17);
			this.Italian.TabIndex = 24;
			this.Italian.Text = "Italian";
			this.Italian.UseVisualStyleBackColor = true;
			this.Button2.FlatStyle = FlatStyle.Flat;
			this.Button2.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button2.Location = new Point(30, 133);
			this.Button2.Name = "Button2";
			this.Button2.Padding = new Padding(0, 3, 0, 3);
			this.Button2.Size = new Size(130, 35);
			this.Button2.TabIndex = 28;
			this.Button2.Text = "Save settings";
			this.Button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Italian);
			base.Controls.Add(this.Spanish);
			base.Controls.Add(this.Deutch);
			base.Controls.Add(this.English);
			base.Controls.Add(this.Label1);
			base.Name = "settings_panel";
			base.Size = new Size(1059, 258);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00009F23 File Offset: 0x00008123
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00009F2D File Offset: 0x0000812D
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00009F36 File Offset: 0x00008136
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00009F40 File Offset: 0x00008140
		internal virtual CheckBox English
		{
			[CompilerGenerated]
			get
			{
				return this._English;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.English_CheckedChanged);
				CheckBox english = this._English;
				if (english != null)
				{
					english.CheckedChanged -= value2;
				}
				this._English = value;
				english = this._English;
				if (english != null)
				{
					english.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00009F83 File Offset: 0x00008183
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00009F90 File Offset: 0x00008190
		internal virtual CheckBox Deutch
		{
			[CompilerGenerated]
			get
			{
				return this._Deutch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Deutch_CheckedChanged);
				CheckBox deutch = this._Deutch;
				if (deutch != null)
				{
					deutch.CheckedChanged -= value2;
				}
				this._Deutch = value;
				deutch = this._Deutch;
				if (deutch != null)
				{
					deutch.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00009FD3 File Offset: 0x000081D3
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00009FE0 File Offset: 0x000081E0
		internal virtual CheckBox Spanish
		{
			[CompilerGenerated]
			get
			{
				return this._Spanish;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Spanish_CheckedChanged);
				CheckBox spanish = this._Spanish;
				if (spanish != null)
				{
					spanish.CheckedChanged -= value2;
				}
				this._Spanish = value;
				spanish = this._Spanish;
				if (spanish != null)
				{
					spanish.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000A023 File Offset: 0x00008223
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000A030 File Offset: 0x00008230
		internal virtual CheckBox Italian
		{
			[CompilerGenerated]
			get
			{
				return this._Italian;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Italian_CheckedChanged);
				CheckBox italian = this._Italian;
				if (italian != null)
				{
					italian.CheckedChanged -= value2;
				}
				this._Italian = value;
				italian = this._Italian;
				if (italian != null)
				{
					italian.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000A073 File Offset: 0x00008273
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000A080 File Offset: 0x00008280
		private virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000A0C4 File Offset: 0x000082C4
		private void settings_panel_Load(object sender, EventArgs e)
		{
			string left = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\Settings\\language.txt");
			bool flag = Operators.CompareString(left, "English", false) == 0;
			if (flag)
			{
				this.English.Checked = true;
			}
			bool flag2 = Operators.CompareString(left, "Deutch", false) == 0;
			if (flag2)
			{
				this.Deutch.Checked = true;
			}
			bool flag3 = Operators.CompareString(left, "Spanish", false) == 0;
			if (flag3)
			{
				this.Spanish.Checked = true;
			}
			bool flag4 = Operators.CompareString(left, "Italian", false) == 0;
			if (flag4)
			{
				this.Italian.Checked = true;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A17C File Offset: 0x0000837C
		private void Button2_Click(object sender, EventArgs e)
		{
			bool @checked = this.English.Checked;
			if (@checked)
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "\\Settings\\language.txt", "English", false);
			}
			bool checked2 = this.Deutch.Checked;
			if (checked2)
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "\\Settings\\language.txt", "Deutch", false);
			}
			bool checked3 = this.Spanish.Checked;
			if (checked3)
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "\\Settings\\language.txt", "Spanish", false);
			}
			bool checked4 = this.Italian.Checked;
			if (checked4)
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "\\Settings\\language.txt", "Italian", false);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000A264 File Offset: 0x00008464
		private void English_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.English.Checked;
			if (@checked)
			{
				this.Deutch.Checked = false;
				this.Italian.Checked = false;
				this.Spanish.Checked = false;
				MyProject.Forms.Form1.DorkGeneratorButton.Text = "Dork generator";
				MyProject.Forms.Form1.ExtractorButton.Text = "Extractor";
				MyProject.Forms.Form1.SettingsButton.Text = "Settings";
				MyProject.Forms.Form1.InfoButton.Text = "Info";
				MyProject.Forms.Form1.Extractor_panel1.Label1.Text = "Urls to extract from:";
				MyProject.Forms.Form1.Extractor_panel1.pagetypesbtn.Text = "Pagetypes";
				MyProject.Forms.Form1.Extractor_panel1.keywordsbtn.Text = "Keywords";
				MyProject.Forms.Form1.Extractor_panel1.dorkbtn.Text = "Dorks";
				MyProject.Forms.Form1.Generate_dorks_panel1.button1.Text = "Dork types";
				MyProject.Forms.Form1.Generate_dorks_panel1.button2.Text = "Domain extentions";
				MyProject.Forms.Form1.Generate_dorks_panel1.button3.Text = "Keywords";
				MyProject.Forms.Form1.Generate_dorks_panel1.button4.Text = "Pagetypes";
				MyProject.Forms.Form1.Generate_dorks_panel1.button5.Text = "Pageformats";
				MyProject.Forms.Form1.Generate_dorks_panel1.button6.Text = "Search functions";
				MyProject.Forms.Form1.Generate_dorks_panel1.GenerateButton.Text = "Generate";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label1.Text = "Dork amount:";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label2.Text = "File number:";
				MyProject.Forms.Form1.Info_panel1.Label1.Text = "Abbreviations:\r\nKW -> Keyword\r\nPT -> Pagetype.\r\nPF -> Pageformat.\r\nSF -> Search function.\r\nDE -> Domain extention.\r\n\r\nOther:\r\nDork amount is the max generated\r\ndorks for each selected dorktype.\r\nFile number example: generated7.txt.";
				MyProject.Forms.Form1.Info_panel1.Label2.Text = "How to make me happy:\r\nI spend a lot of time in this dork generator\r\nand it would be very nice if you want to make me happy.\r\nHere is how you can make me happy:";
				MyProject.Forms.Form1.Info_panel1.Label7.Text = "And last but not least just be friendly to me.";
				MyProject.Forms.Form1.Info_panel1.Label8.Text = "Credits:\r\nMade by thiplol.\r\nGodAntiLeech translated:\r\nDeutch\r\nSpanish\r\nJaKK0 translated:\r\nItalian\r\nTested by TSP members\r\nTSP Team";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox4.Text = "Preset 4";
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000A7F4 File Offset: 0x000089F4
		private void Deutch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Deutch.Checked;
			if (@checked)
			{
				this.English.Checked = false;
				this.Italian.Checked = false;
				this.Spanish.Checked = false;
				MyProject.Forms.Form1.DorkGeneratorButton.Text = "Dork Generator";
				MyProject.Forms.Form1.ExtractorButton.Text = "Extraktor";
				MyProject.Forms.Form1.SettingsButton.Text = "Einstellungen";
				MyProject.Forms.Form1.InfoButton.Text = "Info";
				MyProject.Forms.Form1.Extractor_panel1.Label1.Text = "URLs zum Extrahieren von:";
				MyProject.Forms.Form1.Extractor_panel1.pagetypesbtn.Text = "Seitentypen";
				MyProject.Forms.Form1.Extractor_panel1.keywordsbtn.Text = "Keywords";
				MyProject.Forms.Form1.Extractor_panel1.dorkbtn.Text = "Dorks";
				MyProject.Forms.Form1.Generate_dorks_panel1.button1.Text = "Dork-Typen";
				MyProject.Forms.Form1.Generate_dorks_panel1.button2.Text = "Domain-Erweiterungen";
				MyProject.Forms.Form1.Generate_dorks_panel1.button3.Text = "Keywords";
				MyProject.Forms.Form1.Generate_dorks_panel1.button4.Text = "Seitentypen";
				MyProject.Forms.Form1.Generate_dorks_panel1.button5.Text = "Seitenformate";
				MyProject.Forms.Form1.Generate_dorks_panel1.button6.Text = "Suchfunktionen";
				MyProject.Forms.Form1.Generate_dorks_panel1.GenerateButton.Text = "Generate";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label1.Text = "Dork Menge:";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label2.Text = "Dateinummer:";
				MyProject.Forms.Form1.Info_panel1.Label1.Text = "Abkürzungen:\r\nKW -> Schlüsselwort\r\nPT -> Seitentyp.\r\nPF -> Seitenformat.\r\nSF -> Suchfunktion.\r\nDE -> Domainendung.\r\n\r\nAndere:\r\nDork Menge ist das Maximum generiert\r\nDorks für jeden ausgewählten Dorktyp.\r\nDateinummer Beispiel: generated7.txt. ";
				MyProject.Forms.Form1.Info_panel1.Label2.Text = "Wie man mich glücklich macht:\r\nIch verbringe viel Zeit in diesem Dork-Generator\r\nund es wäre sehr nett, wenn du mich glücklich machen willst.\r\nHier kannst du mich glücklich machen: ";
				MyProject.Forms.Form1.Info_panel1.Label7.Text = "Und last but not least sei einfach freundlich zu mir.";
				MyProject.Forms.Form1.Info_panel1.Label8.Text = "Danksagungen:\r\nHergestellt von Thiplol.\r\nGodAntiLeech übersetzt:\r\nDeutch\r\nSpanisch\r\nJaKK0 übersetzt:\r\nItalienisch\r\nGetestet von TSP-Mitgliedern\r\nTSP-Team ";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox1.Text = "Voreinstellung 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox2.Text = "Voreinstellung 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox3.Text = "Voreinstellung 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox4.Text = "Voreinstellung 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox1.Text = "Voreinstellung 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox2.Text = "Voreinstellung 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox3.Text = "Voreinstellung 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox4.Text = "Voreinstellung 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox1.Text = "Voreinstellung 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox2.Text = "Voreinstellung 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox3.Text = "Voreinstellung 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox4.Text = "Voreinstellung 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox1.Text = "Voreinstellung 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox2.Text = "Voreinstellung 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox3.Text = "Voreinstellung 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox4.Text = "Voreinstellung 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox4.Text = "Preset 4";
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000AD84 File Offset: 0x00008F84
		private void Spanish_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Spanish.Checked;
			if (@checked)
			{
				this.Deutch.Checked = false;
				this.Italian.Checked = false;
				this.English.Checked = false;
				MyProject.Forms.Form1.DorkGeneratorButton.Text = "Generador de Dork";
				MyProject.Forms.Form1.ExtractorButton.Text = "Extractor";
				MyProject.Forms.Form1.SettingsButton.Text = "Configuraciones";
				MyProject.Forms.Form1.InfoButton.Text = "Información";
				MyProject.Forms.Form1.Extractor_panel1.Label1.Text = "Urls para extraer de:";
				MyProject.Forms.Form1.Extractor_panel1.pagetypesbtn.Text = "Tipos de página";
				MyProject.Forms.Form1.Extractor_panel1.keywordsbtn.Text = "Palabras clave";
				MyProject.Forms.Form1.Extractor_panel1.dorkbtn.Text = "Dorks";
				MyProject.Forms.Form1.Generate_dorks_panel1.button1.Text = "Tipos de Dork";
				MyProject.Forms.Form1.Generate_dorks_panel1.button2.Text = "Extensiones de dominio";
				MyProject.Forms.Form1.Generate_dorks_panel1.button3.Text = "Palabras clave";
				MyProject.Forms.Form1.Generate_dorks_panel1.button4.Text = "Tipos de página";
				MyProject.Forms.Form1.Generate_dorks_panel1.button5.Text = "Formatos de página";
				MyProject.Forms.Form1.Generate_dorks_panel1.button6.Text = "Funciones de búsqueda";
				MyProject.Forms.Form1.Generate_dorks_panel1.GenerateButton.Text = "Generar";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label1.Text = "Cantidad de Dork:";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label2.Text = "Número de archivo:";
				MyProject.Forms.Form1.Info_panel1.Label1.Text = "Abreviaturas:\r\nKW -> palabra clave\r\nPT -> Tipo de página.\r\nPF -> Formato de página.\r\nSF -> Función de búsqueda.\r\nDE -> Extencion de dominio.\r\n\r\nOtro:\r\nCantidad de Dork es el máximo generado\r\ndorks para cada dorktype seleccionado.\r\nEjemplo de número de archivo: generated7.txt. ";
				MyProject.Forms.Form1.Info_panel1.Label2.Text = "Cómo hacerme feliz:\r\nPaso mucho tiempo en este generador de dorks\r\ny sería muy lindo si quieres hacerme feliz.\r\nAsí es como puedes hacerme feliz: ";
				MyProject.Forms.Form1.Info_panel1.Label7.Text = "Y por último, pero no menos importante, se amable conmigo.";
				MyProject.Forms.Form1.Info_panel1.Label8.Text = "Créditos:\r\nHecho por thiplol.\r\nGodAntiLeech traducido:\r\nDeutch\r\nEspañol\r\nJaKK0 traducido:\r\nitaliano\r\nProbado por los miembros de TSP\r\nTSP Team ";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox4.Text = "Preset 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox1.Text = "Preset 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox2.Text = "Preset 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox3.Text = "Preset 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox4.Text = "Preset 4";
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B314 File Offset: 0x00009514
		private void Italian_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Italian.Checked;
			if (@checked)
			{
				this.Deutch.Checked = false;
				this.English.Checked = false;
				this.Spanish.Checked = false;
				MyProject.Forms.Form1.DorkGeneratorButton.Text = "Generatore";
				MyProject.Forms.Form1.ExtractorButton.Text = "Estratttore";
				MyProject.Forms.Form1.SettingsButton.Text = "Impostazioni";
				MyProject.Forms.Form1.InfoButton.Text = "Informazioni";
				MyProject.Forms.Form1.Extractor_panel1.Label1.Text = "Urls da cui estrarre Dorks:";
				MyProject.Forms.Form1.Extractor_panel1.pagetypesbtn.Text = "Pagetypes";
				MyProject.Forms.Form1.Extractor_panel1.keywordsbtn.Text = "Keywords";
				MyProject.Forms.Form1.Extractor_panel1.dorkbtn.Text = "Dorks";
				MyProject.Forms.Form1.Generate_dorks_panel1.button1.Text = "Dork types";
				MyProject.Forms.Form1.Generate_dorks_panel1.button2.Text = "dominio";
				MyProject.Forms.Form1.Generate_dorks_panel1.button3.Text = "Keywords";
				MyProject.Forms.Form1.Generate_dorks_panel1.button4.Text = "Pagetypes";
				MyProject.Forms.Form1.Generate_dorks_panel1.button5.Text = "Pageformats";
				MyProject.Forms.Form1.Generate_dorks_panel1.button6.Text = "Search functions";
				MyProject.Forms.Form1.Generate_dorks_panel1.GenerateButton.Text = "Genera!";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label1.Text = "Quantità di Dorks:";
				MyProject.Forms.Form1.Generate_dorks_panel1.Label2.Text = "Numero del file:";
				MyProject.Forms.Form1.Info_panel1.Label1.Text = "Abbreviazioni:\r\nKW -> Keyword.\r\nPT -> Pagetype.\r\nPF -> Pageformat.\r\nSF -> Search function.\r\nDE -> Domain extention.\r\n\r\nAltro:\r\nPer 'Quantità di Dorks'\r\nsi intende il numero massimo di Dorks generate per ogni dorktype selezionato.\r\nEsempio di file di Output: generated7.txt.";
				MyProject.Forms.Form1.Info_panel1.Label2.Text = "Come farmi felice:\r\nHo lavorato molto e continuo a migliorare questo generatore\r\ne sarebbe fanstastico se mi facessi un piccolo favore.\r\nEcco come puoi aiutarmi:";
				MyProject.Forms.Form1.Info_panel1.Label7.Text = "E ricorda sempre di essermi riconoscente";
				MyProject.Forms.Form1.Info_panel1.Label8.Text = "Credits:\r\nCreato da Triphol.\r\nGodAntiLeech ha tradotto in:\r\nTedesco\r\nSpagnolo\r\nJaKK0 ha tradotto in:\r\nItaliano\r\nTestato dai Membri di TSP\r\nTSP Team";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox1.Text = "Predefiniti 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox2.Text = "Predefiniti 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox3.Text = "Predefiniti 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Domainextentions1.checkBox4.Text = "Predefiniti 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox1.Text = "Predefiniti 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox2.Text = "Predefiniti 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox3.Text = "Predefiniti 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Keywords1.checkBox4.Text = "Predefiniti 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox1.Text = "Predefiniti 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox2.Text = "Predefiniti 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox3.Text = "Predefiniti 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pageformats1.checkBox4.Text = "Predefiniti 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox1.Text = "Predefiniti 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox2.Text = "Predefiniti 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox3.Text = "Predefiniti 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Pagetypes1.checkBox4.Text = "Predefiniti 4";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox1.Text = "Predefiniti 1";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox2.Text = "Predefiniti 2";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox3.Text = "Predefiniti 3";
				MyProject.Forms.Form1.Generate_dorks_panel1.Searchfunctions1.checkBox4.Text = "Predefiniti 4";
			}
		}

		// Token: 0x04000080 RID: 128
		private IContainer components;
	}
}
