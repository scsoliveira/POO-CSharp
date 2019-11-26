using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace Notepad
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MainMenu MenuBar;
		private System.Windows.Forms.MenuItem File;
		private System.Windows.Forms.MenuItem New;
		private System.Windows.Forms.MenuItem Open;
		private System.Windows.Forms.MenuItem Save;
		private System.Windows.Forms.MenuItem SaveAs;
		private System.Windows.Forms.MenuItem PageSetup;
		private System.Windows.Forms.MenuItem Print;
		private System.Windows.Forms.MenuItem Exit;
		private System.Windows.Forms.MenuItem Edit;
		private System.Windows.Forms.MenuItem Format;
		private System.Windows.Forms.MenuItem View;
		private System.Windows.Forms.MenuItem Help;
		private System.Windows.Forms.MenuItem Undo;
		private System.Windows.Forms.MenuItem Cut;
		private System.Windows.Forms.MenuItem Copy;
		private System.Windows.Forms.MenuItem Paste;
		private System.Windows.Forms.MenuItem Delete;
		private System.Windows.Forms.MenuItem Find;
		private System.Windows.Forms.MenuItem FindNext;
		private System.Windows.Forms.MenuItem Replace;
		private System.Windows.Forms.MenuItem GoTo;
		private System.Windows.Forms.MenuItem SelectAll;
		private System.Windows.Forms.MenuItem TimeDate;
		private System.Windows.Forms.MenuItem WordWrap;
		private System.Windows.Forms.MenuItem StatusBar;
		private System.Windows.Forms.TextBox TextArea;
		private System.Windows.Forms.MenuItem font;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem AboutMe;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			GetSettings();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		
		#region Windows Form Designer generated code
		
		String tfileName = "Untitled";
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.MenuBar = new System.Windows.Forms.MainMenu();
			this.File = new System.Windows.Forms.MenuItem();
			this.New = new System.Windows.Forms.MenuItem();
			this.Open = new System.Windows.Forms.MenuItem();
			this.Save = new System.Windows.Forms.MenuItem();
			this.SaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.PageSetup = new System.Windows.Forms.MenuItem();
			this.Print = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.Exit = new System.Windows.Forms.MenuItem();
			this.Edit = new System.Windows.Forms.MenuItem();
			this.Undo = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.Cut = new System.Windows.Forms.MenuItem();
			this.Copy = new System.Windows.Forms.MenuItem();
			this.Paste = new System.Windows.Forms.MenuItem();
			this.Delete = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.Find = new System.Windows.Forms.MenuItem();
			this.FindNext = new System.Windows.Forms.MenuItem();
			this.Replace = new System.Windows.Forms.MenuItem();
			this.GoTo = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.SelectAll = new System.Windows.Forms.MenuItem();
			this.TimeDate = new System.Windows.Forms.MenuItem();
			this.Format = new System.Windows.Forms.MenuItem();
			this.WordWrap = new System.Windows.Forms.MenuItem();
			this.font = new System.Windows.Forms.MenuItem();
			this.View = new System.Windows.Forms.MenuItem();
			this.StatusBar = new System.Windows.Forms.MenuItem();
			this.Help = new System.Windows.Forms.MenuItem();
			this.AboutMe = new System.Windows.Forms.MenuItem();
			this.TextArea = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuBar
			// 
			this.MenuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.File,
																					this.Edit,
																					this.Format,
																					this.View,
																					this.Help});
			// 
			// File
			// 
			this.File.Index = 0;
			this.File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.New,
																				 this.Open,
																				 this.Save,
																				 this.SaveAs,
																				 this.menuItem10,
																				 this.PageSetup,
																				 this.Print,
																				 this.menuItem13,
																				 this.Exit});
			this.File.Text = "&File";
			// 
			// New
			// 
			this.New.Index = 0;
			this.New.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.New.Text = "&New";
			this.New.Click += new System.EventHandler(this.New_Click);
			// 
			// Open
			// 
			this.Open.Index = 1;
			this.Open.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.Open.Text = "&Open...";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// Save
			// 
			this.Save.Index = 2;
			this.Save.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.Save.Text = "&Save";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// SaveAs
			// 
			this.SaveAs.Index = 3;
			this.SaveAs.Text = "Save As...";
			this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.Text = "-";
			// 
			// PageSetup
			// 
			this.PageSetup.Index = 5;
			this.PageSetup.Text = "Page Setup";
			this.PageSetup.Click += new System.EventHandler(this.PageSetup_Click);
			// 
			// Print
			// 
			this.Print.Index = 6;
			this.Print.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.Print.Text = "&Print...";
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 7;
			this.menuItem13.Text = "-";
			// 
			// Exit
			// 
			this.Exit.Index = 8;
			this.Exit.Text = "E&xit";
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Edit
			// 
			this.Edit.Index = 1;
			this.Edit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.Undo,
																				 this.menuItem16,
																				 this.Cut,
																				 this.Copy,
																				 this.Paste,
																				 this.Delete,
																				 this.menuItem21,
																				 this.Find,
																				 this.FindNext,
																				 this.Replace,
																				 this.GoTo,
																				 this.menuItem26,
																				 this.SelectAll,
																				 this.TimeDate});
			this.Edit.Text = "&Edit";
			// 
			// Undo
			// 
			this.Undo.Enabled = false;
			this.Undo.Index = 0;
			this.Undo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.Undo.Text = "&Undo";
			this.Undo.Click += new System.EventHandler(this.Undo_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Text = "-";
			// 
			// Cut
			// 
			this.Cut.Enabled = false;
			this.Cut.Index = 2;
			this.Cut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.Cut.Text = "Cu&t";
			this.Cut.Click += new System.EventHandler(this.Cut_Click);
			// 
			// Copy
			// 
			this.Copy.Enabled = false;
			this.Copy.Index = 3;
			this.Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.Copy.Text = "&Copy";
			this.Copy.Click += new System.EventHandler(this.Copy_Click);
			// 
			// Paste
			// 
			this.Paste.Enabled = false;
			this.Paste.Index = 4;
			this.Paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.Paste.Text = "&Paste";
			this.Paste.Click += new System.EventHandler(this.Paste_Click);
			// 
			// Delete
			// 
			this.Delete.Enabled = false;
			this.Delete.Index = 5;
			this.Delete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.Delete.Text = "De&lete";
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 6;
			this.menuItem21.Text = "-";
			// 
			// Find
			// 
			this.Find.Index = 7;
			this.Find.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.Find.Text = "&Find...";
			this.Find.Click += new System.EventHandler(this.Find_Click);
			// 
			// FindNext
			// 
			this.FindNext.Index = 8;
			this.FindNext.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.FindNext.Text = "Find &Next";
			this.FindNext.Click += new System.EventHandler(this.FindNext_Click);
			// 
			// Replace
			// 
			this.Replace.Index = 9;
			this.Replace.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
			this.Replace.Text = "&Replace...";
			this.Replace.Click += new System.EventHandler(this.Replace_Click);
			// 
			// GoTo
			// 
			this.GoTo.Index = 10;
			this.GoTo.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
			this.GoTo.Text = "&Go To...";
			this.GoTo.Click += new System.EventHandler(this.GoTo_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 11;
			this.menuItem26.Text = "-";
			// 
			// SelectAll
			// 
			this.SelectAll.Index = 12;
			this.SelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.SelectAll.Text = "Sellect &All";
			this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
			// 
			// TimeDate
			// 
			this.TimeDate.Index = 13;
			this.TimeDate.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.TimeDate.Text = "Time/&Date";
			this.TimeDate.Click += new System.EventHandler(this.TimeDate_Click);
			// 
			// Format
			// 
			this.Format.Index = 2;
			this.Format.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.WordWrap,
																				   this.font});
			this.Format.Text = "F&ormat";
			// 
			// WordWrap
			// 
			this.WordWrap.Index = 0;
			this.WordWrap.Text = "&Word Wrap";
			this.WordWrap.Click += new System.EventHandler(this.WordWrap_Click);
			// 
			// font
			// 
			this.font.Index = 1;
			this.font.Text = "&Font...";
			this.font.Click += new System.EventHandler(this.font_Click);
			// 
			// View
			// 
			this.View.Index = 3;
			this.View.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.StatusBar});
			this.View.Text = "&View";
			// 
			// StatusBar
			// 
			this.StatusBar.Index = 0;
			this.StatusBar.Text = "&Status Bar";
			this.StatusBar.Click += new System.EventHandler(this.StatusBar_Click);
			// 
			// Help
			// 
			this.Help.Index = 4;
			this.Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.AboutMe});
			this.Help.Text = "&Help";
			// 
			// AboutMe
			// 
			this.AboutMe.Index = 0;
			this.AboutMe.Text = "About &Notepad";
			this.AboutMe.Click += new System.EventHandler(this.AboutMe_Click);
			// 
			// TextArea
			// 
			this.TextArea.AcceptsReturn = true;
			this.TextArea.AcceptsTab = true;
			this.TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TextArea.HideSelection = false;
			this.TextArea.Location = new System.Drawing.Point(0, 0);
			this.TextArea.Multiline = true;
			this.TextArea.Name = "TextArea";
			this.TextArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TextArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextArea.Size = new System.Drawing.Size(592, 345);
			this.TextArea.TabIndex = 0;
			this.TextArea.Text = "";
			this.TextArea.WordWrap = false;
			this.TextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextArea_KeyDown);
			this.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextArea_MouseDown);
			this.TextArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextArea_KeyPress);
			this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
			this.TextArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextArea_KeyUp);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.Filter = "\"Text files|*.txt|All files|*.*\"";
			this.openFileDialog1.ShowHelp = true;
			this.openFileDialog1.ShowReadOnly = true;
			// 
			// fontDialog1
			// 
			this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fontDialog1.ShowEffects = false;
			this.fontDialog1.ShowHelp = true;
			// 
			// printDialog1
			// 
			this.printDialog1.AllowSomePages = true;
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.ShowHelp = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "\"TEXT files|*.txt|All files|*.*\"";
			this.saveFileDialog1.ShowHelp = true;
			// 
			// statusBar1
			// 
			this.statusBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.statusBar1.Location = new System.Drawing.Point(0, 325);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(592, 20);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Visible = false;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Width = 426;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Text = "Ln 1, Col 1";
			this.statusBarPanel2.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 345);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.TextArea);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.MenuBar;
			this.Name = "Form1";
			this.Text = "Untitled - Notepad";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closing += new CancelEventHandler(Form1_Closing);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		int fileCount = 0;
		bool stBar = false;
		DockStyle dc = new DockStyle();
		bool checkText = false;
		bool MCcheck = false;
		string fileName ="";
		static string TextToFind = "";
		static string TextToReplace="";
		static bool IsDirectionDownward=true;

		private void saveFile()
		{
			if ( fileName == "")
			{
				saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
				DialogResult resVal = saveFileDialog1.ShowDialog();
				if ( resVal == DialogResult.Cancel )
				{
					return;
				}
				fileName = saveFileDialog1.FileName;
				this.Text = fileName + " - Notepad";
			}
			try
			{
				StreamWriter stWriter = new StreamWriter(fileName);
				stWriter.WriteLine(TextArea.Text);
				stWriter.Flush();
				stWriter.Close();
				checkText = false;
			}
			catch
			{
				MessageBox.Show(this, "The file "+fileName+" is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void ChangeTextOp()
		{
			if ( checkText )
			{
				DialogResult click = MessageBox.Show(this, "The text in "+tfileName+ fileCount+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
				if ( click == DialogResult.Yes )
				{
					saveFile();
					fileCount++;
					TextArea.Text = "";
					fileName = "";
					TextArea.Clear();
					checkText = false;
					this.Text = tfileName + fileCount + " - Notepad";
				}
				if ( click == DialogResult.No)
				{
					TextArea.Clear();
					fileCount++;
					TextArea.Text = "";
					fileName ="";
					checkText = false;
					this.Text = tfileName + fileCount + " - Notepad";
				}
			}
		}

		private void SaveSettings()
		{
			try
			{
				RegistryKey RegKey = Registry.LocalMachine ;			
				RegKey.CreateSubKey ("WajidAli");
 
				RegKey.SetValue ("FontName",TextArea.Font.FontFamily.GetName(0));
				RegKey.SetValue ("FontSize", Convert.ToString(TextArea.Font.Size));
				
				//RegKey.SetValue ("WordWrap",
			}
			catch
			{
			}
		}

		private void GetSettings()
		{
			try
			{						
				RegistryKey RegKey = Registry.LocalMachine ;
				RegKey.OpenSubKey ("WajidAli");
				
				TextArea.Font =new System.Drawing.Font( RegKey.GetValue ("FontName").ToString() , Convert.ToSingle (RegKey.GetValue ("FontSize")));
			}
			catch
			{
				//Key may not present.Set default values
			}	
		}

		private void TextFindForm()
		{
			Application.EnableVisualStyles();
			Label LabelFind = new Label();
			LabelFind.Location=new Point(5,15);
			LabelFind.Text="Fi&nd what:";
			LabelFind.AutoSize=true;

			TextBox TextBoxFind=new TextBox();
			TextBoxFind.Location=new Point(LabelFind.Left+LabelFind.Width+5,LabelFind.Top);
			TextBoxFind.Size=new Size(200,TextBoxFind.Height);
			TextBoxFind.Text=TextToFind;
			TextBoxFind.TextChanged+=new EventHandler(TextBoxFind_Change);

			Button ButtonFindNext =new Button();
			ButtonFindNext.Text="Find Next";
			ButtonFindNext.DialogResult=DialogResult.OK;
			ButtonFindNext.Location=new Point(TextBoxFind.Left+TextBoxFind.Width+5,LabelFind.Top-2);
			ButtonFindNext.Click+=new EventHandler (ButtonFindNext_Click);

			Button FindCancel=new Button();
			FindCancel.Text="Cancel";
			FindCancel.DialogResult=DialogResult.Cancel;
			FindCancel.Location=new Point(ButtonFindNext.Left,ButtonFindNext.Top+ButtonFindNext.Height+5);
			FindCancel.Click+=new EventHandler(FindCancel_Click);

			GroupBox GroupDirection=new GroupBox();
			GroupDirection.Location = new Point(155,45);
			GroupDirection.Size=new Size(110,47);
			GroupDirection.Text="Direction";

			RadioButton OptionUp=new RadioButton();
			OptionUp.Location=new Point(10,15);
			OptionUp.Click+=new EventHandler(Direction_Click);
			OptionUp.Text="&Up";
			OptionUp.Width=40;

			RadioButton OptionDown=new RadioButton();			
			OptionDown.Location=new Point(50,15);
			OptionDown.Text="&Down";
			OptionDown.Width=55;
			OptionDown.Click+=new EventHandler(Direction_Click);
			OptionDown.Checked=true;

			GroupDirection.Controls.Add(OptionUp);
			GroupDirection.Controls.Add(OptionDown);

			CheckBox CheckMatch=new CheckBox();
			CheckMatch.Location = new Point(10,65);
			CheckMatch.Text="Match &case";
			CheckMatch.Checked = true;
			CheckMatch.Click += new EventHandler(CheckMatch_Click);

			if(TextBoxFind.Text.Trim().Length==0)
				ButtonFindNext.Enabled=false;

			Form FindDialog = new Form();
			FindDialog.Location = new Point ( 250, 350 );
			FindDialog.Size = new Size( 360, 130 );
			FindDialog.Text = "Find";
			FindDialog.MaximizeBox = false;
			FindDialog.MinimizeBox = false;
			FindDialog.ShowInTaskbar=false;
			FindDialog.HelpButton = true;
			FindDialog.FormBorderStyle = FormBorderStyle.FixedDialog;

			FindDialog.Controls.Add(LabelFind);
			FindDialog.Controls.Add(TextBoxFind);
			FindDialog.Controls.Add(ButtonFindNext);
			FindDialog.Controls.Add(FindCancel);
			FindDialog.Controls.Add(GroupDirection);
			FindDialog.Controls.Add(CheckMatch);
			FindDialog.Show();	
		}

		public int GoToLine(string LineNumber)
		{
			Form GoToDialog=new Form();

			TextBox LineBox=new TextBox();
			LineBox.Text=LineNumber;
			LineBox.Location=new Point(10,10);
			if(LineBox.Text.Length==0) 
				LineBox.Text="0";
			
			Button GoToOK=new Button();
			GoToOK.Text="OK";
			GoToOK.DialogResult=DialogResult.OK;
			GoToOK.Location=new Point(LineBox.Left+LineBox.Width+20,10);
			GoToOK.Click-=new EventHandler(Find_Click);

			Button GoToCancel=new Button();
			GoToCancel.Text="Cancel";
			GoToCancel.Location=new Point(GoToOK.Left,GoToOK.Top+GoToOK.Height+10);
			GoToCancel.DialogResult=DialogResult.Cancel;
			
			GoToDialog.Size=new Size(230,100);
			GoToDialog.Text="Go to Line";
			GoToDialog.AcceptButton=GoToOK;
			GoToDialog.CancelButton=GoToCancel;
			GoToDialog.MaximizeBox=false;
			GoToDialog.MinimizeBox=false;
			GoToDialog.FormBorderStyle=FormBorderStyle.FixedDialog;
			GoToDialog.Location=new Point(this.Left+Math.Abs((this.Width-GoToDialog.Width))/2,this.Top + 100);
			
			GoToDialog.Controls.Add(LineBox);
			GoToDialog.Controls.Add(GoToOK);
			GoToDialog.Controls.Add(GoToCancel);
			GoToDialog.ShowDialog(this);

			if(GoToDialog.DialogResult==DialogResult.OK)
			{
				try
				{
					GoToDialog.Dispose();
					return Int32.Parse(LineBox.Text);
				}
				catch(Exception)
				{
					return -1;
				}
			}
			return 0;
		}
		
		public void MoveToLine(int LineNumber)
		{
			int CurrentPos=TextArea.Text.IndexOf("\n");
			int LineCount=0;
			bool IsMoved=false;
			while(CurrentPos >-1 && !IsMoved)       
			{
				LineCount++;
				if(LineNumber==LineCount)
				{
					TextArea.SelectionStart=CurrentPos-1;
					TextArea_KeyUp(null,null);
					IsMoved=true;
				}
				CurrentPos=TextArea.Text.IndexOf("\n",CurrentPos+1);
			}
			if(!IsMoved)
			{
				if(LineNumber==LineCount+1)
					TextArea.SelectionStart=TextArea.Text.Length;
				else
					MessageBox.Show("Line Number Out of Range");
			}
		}

		private void ShowReplace()
		{
			TextBox TextBoxFind=new TextBox();
			TextBox TextBoxReplace=new TextBox();
			Label LabelFind=new Label();
			Label LabelReplace=new Label();
			CheckBox CheckBoxMatch=new CheckBox();
			GroupBox GroupDirection=new GroupBox();
			RadioButton OptionUp=new RadioButton();
			RadioButton OptionDown=new RadioButton();
			Button ReplaceOK=new Button();
			Button ReplaceReplaceALL=new Button();
			Button ReplaceCancel=new Button();

			ReplaceOK.Text="Replace";
			ReplaceOK.DialogResult=DialogResult.OK;
			ReplaceOK.Click+=new EventHandler(ReplaceString_Click);

			ReplaceReplaceALL.Text="Replace All";
			ReplaceReplaceALL.DialogResult=DialogResult.OK;
			ReplaceReplaceALL.Click+=new EventHandler(ReplaceALL_Click);

			ReplaceCancel.Text="Cancel";
			ReplaceCancel.DialogResult=DialogResult.Cancel;
			ReplaceCancel.Click+=new EventHandler(FindCancel_Click);

			Form ReplaceDialog=new Form();
			ReplaceDialog.Size=new Size(360,150);
			ReplaceDialog.Text="Replace";
			ReplaceDialog.MaximizeBox=false;
			ReplaceDialog.MinimizeBox=false;
			ReplaceDialog.FormBorderStyle=FormBorderStyle.FixedDialog;

			LabelFind.Location=new Point(10,15);
			LabelFind.Text="Find:";
			LabelFind.AutoSize=true;
    
			TextBoxFind.Location=new Point(55,15);
			TextBoxFind.Size=new Size(200,TextBoxFind.Height);
			TextBoxFind.Text=TextToFind;
			TextBoxFind.TextChanged+=new EventHandler(TextBoxFind_Change);

			LabelReplace.Location=new Point(10,43);
			LabelReplace.Text="Replace:";
			LabelReplace.AutoSize=true;
    
			TextBoxReplace.Location=new Point(55,43);
			TextBoxReplace.Size=new Size(200,TextBoxFind.Height);
			TextBoxFind.Left=TextBoxReplace.Left;
			TextBoxReplace.Text=TextToReplace;
			TextBoxReplace.TextChanged+=new EventHandler(TextBoxReplace_Change);
    

			ReplaceOK.Location=new Point(265,15);
			ReplaceReplaceALL.Location=new Point(265,43);
			ReplaceCancel.Location=new Point(265,70);

			GroupDirection.Location=new Point(135,70);
			GroupDirection.Size=new Size(120,45);
			GroupDirection.Text="Match Direction";

			OptionUp.Location=new Point(10,15);
			OptionUp.Click+=new EventHandler(Direction_Click);
			OptionUp.Text="&Up";
			OptionUp.Width=45;

			OptionDown.Text="&Down";
			OptionDown.Width=55;
			OptionDown.Click+=new EventHandler(Direction_Click);
			OptionDown.Checked=true;
			OptionDown.Location=new Point(OptionUp.Left+OptionUp.Width,OptionUp.Top);

			GroupDirection.Controls.Add(OptionUp);
			GroupDirection.Controls.Add(OptionDown);

			CheckBoxMatch.Location=new Point(10,85);
			CheckBoxMatch.Text="Match Case";
			CheckBoxMatch.Checked = true;

			if(TextBoxFind.Text.Trim().Length==0)
			{
				ReplaceOK.Enabled=false;
				ReplaceReplaceALL.Enabled=false;
			}

			ReplaceDialog.Controls.Add(TextBoxFind);
			ReplaceDialog.Controls.Add(LabelFind);
			ReplaceDialog.Controls.Add(TextBoxReplace);
			ReplaceDialog.Controls.Add(LabelReplace);
			ReplaceDialog.Controls.Add(GroupDirection);
			ReplaceDialog.Controls.Add(CheckBoxMatch);
			ReplaceDialog.Controls.Add(ReplaceOK);
			ReplaceDialog.Controls.Add(ReplaceReplaceALL);
			ReplaceDialog.Controls.Add(ReplaceCancel);
			ReplaceDialog.ShowInTaskbar=false;
			ReplaceDialog.TopMost=true;
			ReplaceDialog.HelpButton = true;
			ReplaceDialog.Show();

		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}	

		protected void Form1_Load ( object sender, System.EventArgs e)
		{
			if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
				Paste.Enabled = true;
		}

		protected void Form1_Resize (object sender, System.EventArgs e)
		{
			TextArea.Width =this.Width-10 ; 
			TextArea.Height =this.Height-70 ;
		}

		protected void Form1_Closing (object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ( checkText )
			{
				DialogResult click;
				if ( fileName == "" )
				{
					if ( fileCount == 0 )
						click = MessageBox.Show(this, "The text in "+tfileName+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);					
					else
						click = MessageBox.Show(this, "The text in "+tfileName+fileCount+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
				}
				else
					click = MessageBox.Show(this, "The text in "+fileName+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
				if ( click == DialogResult.Yes )
				{
					saveFile();
					SaveSettings();
					this.Dispose();
				}
				if ( click == DialogResult.Cancel )
					return;
				else
				{
					this.Dispose();
					SaveSettings();
				}
			}
			else
			{
				this.Dispose();
				SaveSettings();
			}
		}

		private void TextArea_TextChanged(object sender, System.EventArgs e)
		{
			checkText = true;
			Undo.Enabled = true;
		}

		private void TextArea_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				int ColCount=1;
				int RowCount=1;
				int Pos;
				if(TextArea.SelectionStart>-1)
				{
					Pos=TextArea.Text.LastIndexOf("\n",TextArea.SelectionStart);
					if(Pos>-1)
					{
						if(Pos!=TextArea.SelectionStart)
							ColCount=TextArea.SelectionStart-Pos;
						else
						{
							Pos=TextArea.Text.LastIndexOf("\n",TextArea.SelectionStart-1);            
							ColCount=TextArea.SelectionStart-Pos;
						}
					}
					else
					{
						ColCount=TextArea.SelectionStart+1;
					}
					while(Pos>-1)
					{
						RowCount++;
						Pos=TextArea.Text.LastIndexOf("\n",Pos-1);
					}
				}
				statusBar1.Panels[1].Text="Ln " + RowCount.ToString()+ ", "+ "Col " + ColCount.ToString();
			}
			catch(Exception)
			{
			}
		}

		private void TextArea_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextArea_KeyUp ( null, null );
		}
		
		private void TextArea_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.F1 && e.Modifiers == Keys.Shift ||
				e.KeyCode == Keys.End && e.Modifiers == Keys.Shift ||
				e.KeyCode == Keys.Right && e.Modifiers == Keys.Shift ||
				e.KeyCode == Keys.Left && e.Modifiers == Keys.Shift ||
				e.KeyCode == Keys.Up && e.Modifiers == Keys.Shift ||
				e.KeyCode == Keys.Down && e.Modifiers == Keys.Shift ||
				e.Modifiers == Keys.Alt || e.Modifiers == Keys.Control)
			{
				if ( TextArea.SelectionLength > 0 )
				{
					Cut.Enabled = true;
					Copy.Enabled = true;
					Delete.Enabled = true;
				}
			}
			else
			{
				Cut.Enabled = false;
				Copy.Enabled = false;
				Delete.Enabled = false;
			}
		}

		private void TextArea_MouseDown(object sneder, MouseEventArgs e)
		{
			TextArea_KeyUp ( null, null );
		}

		private void New_Click(object sender, System.EventArgs e)
		{
			ChangeTextOp();
		}

		private void Open_Click(object sender, System.EventArgs e)
		{
			try
			{
				openFileDialog1.ShowDialog();
				fileName = openFileDialog1.FileName;
				StreamReader stReader = new StreamReader(fileName);
				TextArea.Text = stReader.ReadToEnd();
				checkText = false;
				stReader.Close();
				this.Text = fileName + " - Notepad";
				fileName = "";
			}
			catch{
			}
		}

		private void Save_Click(object sender, System.EventArgs e)
		{
			saveFile();
		}

		private void SaveAs_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
			fileName = saveFileDialog1.FileName;
			saveFile();
		}

		private void PageSetup_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = tfileName;
			pageSetupDialog1.Document = printDocument1;
			pageSetupDialog1.ShowDialog();
		}

		private void Print_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = tfileName;
			printDialog1.Document = printDocument1;
			printDialog1.ShowDialog();
		}

		private void Exit_Click(object sender, System.EventArgs e)
		{
			if ( checkText )
			{
				DialogResult click;
				if ( fileName == "" )
				{
					if ( fileCount == 0)
						click = MessageBox.Show(this, "The text in "+tfileName+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
					else
						click = MessageBox.Show(this, "The text in "+tfileName+fileCount+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
				}
				else
					click = MessageBox.Show(this, "The text in "+fileName+" file has changes. \n\nDo you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
				if ( click == DialogResult.Yes )
				{
					saveFile();
					SaveSettings();
					this.Dispose();
				}
				if ( click == DialogResult.Cancel )
					return;
				else
				{
					this.Dispose();
					SaveSettings();
				}
			}
			else
			{
				this.Dispose();
				SaveSettings();
			}
		}

		private void Undo_Click(object sender, System.EventArgs e)
		{
			if(TextArea.CanUndo == true)
			{
				TextArea.Undo();
				TextArea.ClearUndo();
			}
			TextArea_KeyUp(null, null);
			checkText = true;
		}

		private void Cut_Click(object sender, System.EventArgs e)
		{
			if ( TextArea.SelectedText != "" && Cut.Enabled == true)
			{
				TextArea.Cut();
				TextArea_KeyUp(null, null);
				checkText = true;
			}
		}

		private void Copy_Click(object sender, System.EventArgs e)
		{
			if ( TextArea.SelectionLength > 0)
			{
				TextArea.Copy();
				TextArea_KeyUp(null, null);
				checkText = true;
			}
		}

		private void Paste_Click(object sender, System.EventArgs e)
		{
			if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
			{
				TextArea.Paste();	
			}
			TextArea_KeyUp(null, null);
			checkText = true;
		}

		private void Delete_Click(object sender, System.EventArgs e)
		{
			if ( TextArea.SelectionLength > 0)
			{
				TextArea.SelectedText = "";
				TextArea_KeyUp(null, null);
				checkText = true;
			}
		}

		private void Find_Click(object sender, System.EventArgs e)
		{
			TextFindForm();
		}

		private void FindNext_Click(object sender, System.EventArgs e)
		{
			ButtonFindNext_Click(null,null);
		}

		private void Replace_Click(object sender, System.EventArgs e)
		{
			ShowReplace();
		}

		private void GoTo_Click(object sender, System.EventArgs e)
		{
			int LineNumber=GoToLine(statusBar1.Panels[1].Text.Substring(0).Trim());
			if(LineNumber>0)
			{
				MoveToLine(LineNumber);
			}
			else
			{
				if(LineNumber<0)
					MessageBox.Show("Invalid Line Number.");          
			}
			TextArea_KeyUp(null, null);
		}

		private void SelectAll_Click(object sender, System.EventArgs e)
		{
			TextArea.SelectAll();
			checkText = true;
		}

		private void TimeDate_Click(object sender, System.EventArgs e)
		{
			TextArea.Text = TextArea.Text + DateTime.Now.ToLongTimeString() + " " +DateTime.Now.ToLongDateString();
			TextArea.SelectionLength = TextArea.Text.Length;
			TextArea.SelectionStart = TextArea.Text.Length;
			checkText = false;
		}
		
		private void WordWrap_Click(object sender, System.EventArgs e)
		{
			if ( !(WordWrap.Checked) )
			{
				WordWrap.Checked = true;
				TextArea.WordWrap = true;
				StatusBar.Enabled = false;
				if ( stBar == true )
				{
					statusBar1.Visible = false;
					dc = DockStyle.Fill;
					TextArea.Dock = dc;
				}
			}
			else
			{
				WordWrap.Checked = false;
				TextArea.WordWrap = false;
				StatusBar.Enabled = true;
				statusBar1.Visible = true;
				if ( stBar == true )
				{
					dc = DockStyle.None;
					TextArea.Dock = dc;
					statusBar1.Visible = true;
				}
				else
					statusBar1.Visible = false;	
			}
		}

		private void font_Click(object sender, System.EventArgs e)
		{
			fontDialog1.ShowColor = true;
			fontDialog1.ShowDialog();
			TextArea.Font = fontDialog1.Font;
			TextArea.ForeColor = fontDialog1.Color;
		}
		
		private void StatusBar_Click(object sender, System.EventArgs e)
		{
			if ( !(StatusBar.Checked) )
			{
				StatusBar.Checked = true;
				dc = DockStyle.None;
				this.TextArea.Dock = dc;
				statusBar1.Visible =true;
				stBar = true;
			}
			else
			{
				StatusBar.Checked = false;
				statusBar1.Visible =false;
				dc = DockStyle.Fill;
				this.TextArea.Dock = dc;
				stBar = false;
			}
		}

		private void AboutMe_Click(object sender, System.EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
		}

		// SubForms Events
		private void TextBoxFind_Change(object sender,EventArgs eArgs)
		{    
			TextToFind=((TextBox)sender).Text;
			Form FormTemp=(Form)(((Control)sender).Parent);
			for(int i=0;i<FormTemp.Controls.Count;i++)
			{
				if(FormTemp.Controls[i].GetType() ==typeof(Button) && FormTemp.Controls[i].Text!="&Cancel")
				{
					FormTemp.Controls[i].Enabled=(((TextBox)sender).Text.Length>0);
				}
			}
			FormTemp=null;
		}

		private void ButtonFindNext_Click(object sender,EventArgs eArgs)
		{
			int Pos=-1;

			if(IsDirectionDownward)
			{
				if(TextArea.SelectionLength==0)
					Pos=TextArea.Text.IndexOf(TextToFind,TextArea.SelectionStart);
				else
					Pos=TextArea.Text.IndexOf(TextToFind,TextArea.SelectionStart+TextArea.SelectionLength);
			}
			else
			{
				if(TextArea.SelectionStart>0)
					Pos=TextArea.Text.LastIndexOf(TextToFind,TextArea.SelectionStart-1);
			}
			if(Pos!=-1)
			{
				TextArea.SelectionStart=Pos;
				TextArea.SelectionLength=TextToFind.Length;
				if(sender!=null) 
					((Control)sender).Focus();
			}
			else
			{
				MessageBox.Show("Cannot Find: \"" + TextToFind + "\"");
			}
		}
		private void Direction_Click(object sender,EventArgs eArgs)
		{
			string Caption=((RadioButton)sender).Text;
			if(Caption=="&Up")
				IsDirectionDownward=false;
			else
				IsDirectionDownward=true;
		}

		private void CheckMatch_Click(object sender,EventArgs e)
		{
			if (((CheckBox)sender).Checked)
				MCcheck = true;
			else
				MCcheck = false;
		}

		private void FindCancel_Click(object sender,EventArgs e)
		{
			((Form)((Control)sender).Parent).Close();
		}
		private void TextBoxReplace_Change(object sender,EventArgs eArgs)
		{    
			TextToReplace=((TextBox)sender).Text;
		}

		private void ReplaceString_Click(object sender,EventArgs eArgs)
		{
			ButtonFindNext_Click(null,null);
			if(TextArea.SelectionLength>0)
			{
				TextArea.SelectedText=TextToReplace;
				TextArea.SelectionStart=TextArea.SelectionStart+TextToReplace.Length;
			}
		}
		private void ReplaceALL_Click(object sender,EventArgs eArgs)
		{
			TextArea.Text=ReplaceString(TextArea.Text,TextToFind,TextToReplace);
		}

		private string ReplaceString(string StrSource,string StrFind,string StrReplace)
		{
			int iPos=StrSource.IndexOf(StrFind);
			String StrReturn="";

			while(iPos!=-1)
			{
				StrReturn+=StrSource.Substring(0,iPos)+StrReplace;
				StrSource=StrSource.Substring(iPos+StrFind.Length);
				iPos=StrSource.IndexOf(StrFind);
			}
			if(StrSource.Length>0)
				StrReturn+=StrSource;
			return StrReturn;
		}
	}
}
