namespace WindowsFormsApp1
{
    partial class Frm_BiwTestBase64Frm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BiwTestBase64Frm));
			this.Pnl_Encode = new System.Windows.Forms.Panel();
			this.Grp_Encode = new System.Windows.Forms.GroupBox();
			this.Txt_Encode = new System.Windows.Forms.TextBox();
			this.Pnl_Decode = new System.Windows.Forms.Panel();
			this.Grp_Decode = new System.Windows.Forms.GroupBox();
			this.Txt_Decode = new System.Windows.Forms.TextBox();
			this.Btn_WriteXml = new System.Windows.Forms.Button();
			this.Btn_Decode = new System.Windows.Forms.Button();
			this.Btn_Encode = new System.Windows.Forms.Button();
			this.Tlp_Main = new System.Windows.Forms.TableLayoutPanel();
			this.Tlp_Btn = new System.Windows.Forms.TableLayoutPanel();
			this.Pnl_Local = new System.Windows.Forms.Panel();
			this.Btn_Local = new System.Windows.Forms.Button();
			this.Txt_SaveLocal = new System.Windows.Forms.TextBox();
			this.Pnl_Encode.SuspendLayout();
			this.Grp_Encode.SuspendLayout();
			this.Pnl_Decode.SuspendLayout();
			this.Grp_Decode.SuspendLayout();
			this.Tlp_Main.SuspendLayout();
			this.Tlp_Btn.SuspendLayout();
			this.Pnl_Local.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pnl_Encode
			// 
			this.Pnl_Encode.Controls.Add(this.Grp_Encode);
			resources.ApplyResources(this.Pnl_Encode, "Pnl_Encode");
			this.Pnl_Encode.Name = "Pnl_Encode";
			// 
			// Grp_Encode
			// 
			this.Grp_Encode.Controls.Add(this.Txt_Encode);
			resources.ApplyResources(this.Grp_Encode, "Grp_Encode");
			this.Grp_Encode.Name = "Grp_Encode";
			this.Grp_Encode.TabStop = false;
			// 
			// Txt_Encode
			// 
			resources.ApplyResources(this.Txt_Encode, "Txt_Encode");
			this.Txt_Encode.Name = "Txt_Encode";
			this.Txt_Encode.TextChanged += new System.EventHandler(this.Txt_Change);
			// 
			// Pnl_Decode
			// 
			this.Pnl_Decode.Controls.Add(this.Grp_Decode);
			resources.ApplyResources(this.Pnl_Decode, "Pnl_Decode");
			this.Pnl_Decode.Name = "Pnl_Decode";
			// 
			// Grp_Decode
			// 
			this.Grp_Decode.Controls.Add(this.Txt_Decode);
			resources.ApplyResources(this.Grp_Decode, "Grp_Decode");
			this.Grp_Decode.Name = "Grp_Decode";
			this.Grp_Decode.TabStop = false;
			// 
			// Txt_Decode
			// 
			resources.ApplyResources(this.Txt_Decode, "Txt_Decode");
			this.Txt_Decode.Name = "Txt_Decode";
			this.Txt_Decode.TextChanged += new System.EventHandler(this.Txt_Change);
			// 
			// Btn_WriteXml
			// 
			resources.ApplyResources(this.Btn_WriteXml, "Btn_WriteXml");
			this.Btn_WriteXml.Name = "Btn_WriteXml";
			this.Btn_WriteXml.UseVisualStyleBackColor = true;
			this.Btn_WriteXml.Click += new System.EventHandler(this.Btn_WriteXml_Click);
			// 
			// Btn_Decode
			// 
			resources.ApplyResources(this.Btn_Decode, "Btn_Decode");
			this.Btn_Decode.Name = "Btn_Decode";
			this.Btn_Decode.UseVisualStyleBackColor = true;
			this.Btn_Decode.Click += new System.EventHandler(this.Btn_Decode_Click);
			// 
			// Btn_Encode
			// 
			resources.ApplyResources(this.Btn_Encode, "Btn_Encode");
			this.Btn_Encode.Name = "Btn_Encode";
			this.Btn_Encode.UseVisualStyleBackColor = true;
			this.Btn_Encode.Click += new System.EventHandler(this.Btn_Encode_Click);
			// 
			// Tlp_Main
			// 
			resources.ApplyResources(this.Tlp_Main, "Tlp_Main");
			this.Tlp_Main.Controls.Add(this.Pnl_Decode, 0, 2);
			this.Tlp_Main.Controls.Add(this.Pnl_Encode, 0, 0);
			this.Tlp_Main.Controls.Add(this.Tlp_Btn, 0, 1);
			this.Tlp_Main.Controls.Add(this.Pnl_Local, 0, 3);
			this.Tlp_Main.Name = "Tlp_Main";
			// 
			// Tlp_Btn
			// 
			resources.ApplyResources(this.Tlp_Btn, "Tlp_Btn");
			this.Tlp_Btn.Controls.Add(this.Btn_WriteXml, 2, 0);
			this.Tlp_Btn.Controls.Add(this.Btn_Decode, 1, 0);
			this.Tlp_Btn.Controls.Add(this.Btn_Encode, 0, 0);
			this.Tlp_Btn.Name = "Tlp_Btn";
			// 
			// Pnl_Local
			// 
			this.Pnl_Local.Controls.Add(this.Btn_Local);
			this.Pnl_Local.Controls.Add(this.Txt_SaveLocal);
			resources.ApplyResources(this.Pnl_Local, "Pnl_Local");
			this.Pnl_Local.Name = "Pnl_Local";
			// 
			// Btn_Local
			// 
			resources.ApplyResources(this.Btn_Local, "Btn_Local");
			this.Btn_Local.Name = "Btn_Local";
			this.Btn_Local.UseVisualStyleBackColor = true;
			this.Btn_Local.Click += new System.EventHandler(this.Btn_Local_Click);
			// 
			// Txt_SaveLocal
			// 
			resources.ApplyResources(this.Txt_SaveLocal, "Txt_SaveLocal");
			this.Txt_SaveLocal.Name = "Txt_SaveLocal";
			// 
			// Frm_BiwTestBase64Frm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Tlp_Main);
			this.Name = "Frm_BiwTestBase64Frm";
			this.Pnl_Encode.ResumeLayout(false);
			this.Grp_Encode.ResumeLayout(false);
			this.Grp_Encode.PerformLayout();
			this.Pnl_Decode.ResumeLayout(false);
			this.Grp_Decode.ResumeLayout(false);
			this.Grp_Decode.PerformLayout();
			this.Tlp_Main.ResumeLayout(false);
			this.Tlp_Btn.ResumeLayout(false);
			this.Tlp_Btn.PerformLayout();
			this.Pnl_Local.ResumeLayout(false);
			this.Pnl_Local.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel Pnl_Encode;
		private System.Windows.Forms.Panel Pnl_Decode;
		private System.Windows.Forms.Button Btn_Decode;
		private System.Windows.Forms.Button Btn_Encode;
		private System.Windows.Forms.TableLayoutPanel Tlp_Main;
		private System.Windows.Forms.GroupBox Grp_Encode;
		private System.Windows.Forms.TextBox Txt_Decode;
		private System.Windows.Forms.TextBox Txt_Encode;
		private System.Windows.Forms.GroupBox Grp_Decode;
		private System.Windows.Forms.Button Btn_WriteXml;
		private System.Windows.Forms.TableLayoutPanel Tlp_Btn;
		private System.Windows.Forms.Panel Pnl_Local;
		private System.Windows.Forms.Button Btn_Local;
		private System.Windows.Forms.TextBox Txt_SaveLocal;
	}
}