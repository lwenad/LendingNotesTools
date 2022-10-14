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
        private List<ProsperNoteInfo> _prosperNotesList;
        private BackgroundWorker backgroundWorker1 = new BackgroundWorker(); 
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            _prosperNotesList = new List<ProsperNoteInfo>();
        }




        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=new DoWorkEventHandler(backgroundWorker1_DoWork);
            
// backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
          
       //     backgroundWorker1.ProgressChanged +=new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          //  this.progressBarNote.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using(StreamReader file = new StreamReader(_filePath)) {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if(counter != 0)
                    {
                        string[] lineArray = ln.Split(",");
                        _prosperNotesList.Add(
                            new ProsperNoteInfo()
                            {
                                Rating = lineArray[0],
                                NoteId = lineArray[1],
                                InvestmentAmount = Convert.ToDecimal(lineArray[2].Trim('$')),
                                Term = lineArray[3],
                                PurchaseDate = Convert.ToDateTime(lineArray[4]),
                                PaymentDueDate = Convert.ToDateTime(lineArray[5]),
                                PaymentsReceived = Convert.ToDecimal(lineArray[6].Trim('$')),
                                PrincipalOutstanding = Convert.ToDecimal(lineArray[7].Trim('$')),
                                Yield = lineArray[8],
                                Status = lineArray[9],
                                SubStatus = lineArray[10]
                            });
                    }
                    counter++;

                    if (TextBoxResult.InvokeRequired)
                    {
                        TextBoxResult.Invoke(new MethodInvoker(delegate {
                            TextBoxResult.Text = $"{TextBoxResult.Text}{counter}:{ln}\r\n";
                        }));
                    }


                    if (LabelRowCount.InvokeRequired)
                    {
                        LabelRowCount.Invoke(new MethodInvoker(delegate {
                            LabelRowCount.Text = counter.ToString();
                        }));
                    }

                  
                }
                file.Close();
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK )
                {
                    _filePath = ofd.FileName;
                    this.TextBoxOpenfile.Text = _filePath;
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
