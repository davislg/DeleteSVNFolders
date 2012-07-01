namespace DeleteSvnFolders {
    partial class Form1 {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
	    if (disposing && (components != null)) {
		components.Dispose();
	    }
	    base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
	    this.btnBrowse = new System.Windows.Forms.Button();
	    this.lblStartFolder = new System.Windows.Forms.Label();
	    this.txtFolder = new System.Windows.Forms.TextBox();
	    this.btnDelete = new System.Windows.Forms.Button();
	    this.fbd = new System.Windows.Forms.FolderBrowserDialog();
	    this.btnCancel = new System.Windows.Forms.Button();
	    this.SuspendLayout();
	    // 
	    // btnBrowse
	    // 
	    this.btnBrowse.Location = new System.Drawing.Point(318, 10);
	    this.btnBrowse.Name = "btnBrowse";
	    this.btnBrowse.Size = new System.Drawing.Size(25, 23);
	    this.btnBrowse.TabIndex = 2;
	    this.btnBrowse.Text = "...";
	    this.btnBrowse.UseVisualStyleBackColor = true;
	    this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
	    // 
	    // lblStartFolder
	    // 
	    this.lblStartFolder.AutoSize = true;
	    this.lblStartFolder.Location = new System.Drawing.Point(12, 15);
	    this.lblStartFolder.Name = "lblStartFolder";
	    this.lblStartFolder.Size = new System.Drawing.Size(39, 13);
	    this.lblStartFolder.TabIndex = 0;
	    this.lblStartFolder.Text = "Folder:";
	    // 
	    // txtFolder
	    // 
	    this.txtFolder.Location = new System.Drawing.Point(57, 12);
	    this.txtFolder.Name = "txtFolder";
	    this.txtFolder.Size = new System.Drawing.Size(255, 20);
	    this.txtFolder.TabIndex = 1;
	    // 
	    // btnDelete
	    // 
	    this.btnDelete.Location = new System.Drawing.Point(278, 39);
	    this.btnDelete.Name = "btnDelete";
	    this.btnDelete.Size = new System.Drawing.Size(65, 23);
	    this.btnDelete.TabIndex = 3;
	    this.btnDelete.TabStop = false;
	    this.btnDelete.Text = "Delete";
	    this.btnDelete.UseVisualStyleBackColor = true;
	    this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
	    // 
	    // btnCancel
	    // 
	    this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
	    this.btnCancel.Location = new System.Drawing.Point(207, 39);
	    this.btnCancel.Name = "btnCancel";
	    this.btnCancel.Size = new System.Drawing.Size(65, 23);
	    this.btnCancel.TabIndex = 4;
	    this.btnCancel.TabStop = false;
	    this.btnCancel.Text = "Cancel";
	    this.btnCancel.UseVisualStyleBackColor = true;
	    this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
	    // 
	    // Form1
	    // 
	    this.AcceptButton = this.btnDelete;
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.CancelButton = this.btnCancel;
	    this.ClientSize = new System.Drawing.Size(348, 71);
	    this.Controls.Add(this.btnCancel);
	    this.Controls.Add(this.btnDelete);
	    this.Controls.Add(this.txtFolder);
	    this.Controls.Add(this.lblStartFolder);
	    this.Controls.Add(this.btnBrowse);
	    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
	    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	    this.MaximizeBox = false;
	    this.MinimizeBox = false;
	    this.Name = "Form1";
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Delete SVN Folders";
	    this.ResumeLayout(false);
	    this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Button btnBrowse;
	private System.Windows.Forms.Label lblStartFolder;
	private System.Windows.Forms.TextBox txtFolder;
	private System.Windows.Forms.Button btnDelete;
	private System.Windows.Forms.FolderBrowserDialog fbd;
	private System.Windows.Forms.Button btnCancel;
    }
}

