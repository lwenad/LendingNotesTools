using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LendingNotesTools
{
    public partial class Form1 : Form
    {

        private string _filePath;
        private BackgroundWorker backgroundWorker1 = new BackgroundWorker(); 
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }


        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=new DoWorkEventHandler(backgroundWorker1_DoWork);
            
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
          
            backgroundWorker1.ProgressChanged +=new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

    


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
