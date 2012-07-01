using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeleteSvnFolders {
  public partial class Form1 : Form {

    private const String FOLDER_TO_DELETE_MASK = ".svn";
    private Core.IO.Console console = new Core.IO.Console();
    //private Core.IO.Log errorLog = null;
    private Boolean error = false;
    private Int32 indexPass = 1;

    public Form1() {
      InitializeComponent();
      console.Show();
    }

    private void btnBrowse_Click(object sender, EventArgs e) {
      SetFolder();
    }

    private void SetFolder() {
      fbd.ShowNewFolderButton = false;
      fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
      DialogResult result = fbd.ShowDialog();
      if (result == DialogResult.OK) {
        txtFolder.Text = fbd.SelectedPath;
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      indexPass = 1;
      DeleteFolder();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      Cancel();
    }

    public void DeleteFolder() {
      this.Cursor = Cursors.WaitCursor;
      this.btnDelete.Enabled = false;

      if (txtFolder.Text == String.Empty) {
        MessageBox.Show("Please choose a folder to begin in first.", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      this.error = false;
      console.Clear();
      console.WriteLine("Running pass: " + indexPass);
      console.WriteSeparator();

      DeleteFolder(txtFolder.Text, false);

      // Need to run a second time to ensure files & folders are cleared.
      //this.error = false;
      //console.Clear();
      //DeleteFolder(txtFolder.Text, false);

      if (!error) {
        //MessageBox.Show(".svn Folders Removed!", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        console.WriteLine(".svn Folders Removed!");
        //console.WriteSeparator();
        console.WriteLine("Complete!");

        this.Cursor = Cursors.Default;
      }
      else {
        indexPass++;
        DeleteFolder();
      }
      this.btnDelete.Enabled = true;
      this.Cursor = Cursors.Default;
    }

    public void DeleteFolder(String folderName, Boolean maskSet) {
      DirectoryInfo startFolder = null;
      DirectoryInfo[] subFolders = null;
      try {
        startFolder = new DirectoryInfo(folderName);
        subFolders = startFolder.GetDirectories();
        foreach (DirectoryInfo folder in subFolders) {
          try {
            if (folder.Name == FOLDER_TO_DELETE_MASK) {
              if (folder.GetFiles().Length > 0) {
                DeleteFiles(folder);
              }
              if (folder.GetDirectories().Length > 0) {
                //folder.Delete(true);
                DeleteFolder(folder.FullName, true);
              }
              folder.Delete(true);
              maskSet = false;
            }
            else if (maskSet) {
              if (folder.GetFiles().Length > 0) {
                DeleteFiles(folder);
              }
              if (folder.GetDirectories().Length > 0) {
                //folder.Delete(true);
                DeleteFolder(folder.FullName, maskSet);
              }
              folder.Attributes = FileAttributes.Normal;
              folder.Refresh();
              folder.Delete(true);
              maskSet = false;
            }
            else {
              if (folder.GetDirectories().Length > 0) {
                DeleteFolder(folder.FullName, false);
              }
            }
          }
          catch (Exception ex) {
            this.error = true;
            //console.WriteLine("Folder: " + folder.FullName);
            //console.WriteLine(ex.ToString());
            //console.WriteSeparator();
          }

        }
      }
      catch (Exception ex) {
        this.error = true;
        //console.WriteLine("Folder: " + folderName);
        //console.WriteLine(ex.ToString());
        //console.WriteSeparator();
      }
    }

    public void DeleteFiles(DirectoryInfo folder) {
      FileInfo[] files = folder.GetFiles();
      foreach (FileInfo file in files) {
        file.Attributes = FileAttributes.Normal;
        file.Refresh();
        file.Delete();
      }
    }

    public void Cancel() {
      Application.Exit();
    }
  }
}
