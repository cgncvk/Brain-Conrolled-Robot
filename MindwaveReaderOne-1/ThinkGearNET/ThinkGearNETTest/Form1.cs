
/**
 * ThinkGearNET (Version 8)
 * This code was written by
 * Brian Peek
 * https://thinkgearnet.codeplex.com/
 * http://channel9.msdn.com/coding4fun/articles/MindBlaster
 * 
 * This code is Open Source
 */

/**
 * Mindwave Reader One is written in C# 2010
 */

/**
 * Mindwave Reader One (One line per second) – Version 1
 * A modified version of ThinkGearNet designed to
 * read EEG from a Mindwave and save the results to a .csv file
 * by katie356
 * a project of alphagammawaves Blog
 * Mindwave Reader One - Version 1 - April 2015
 * https://alphagammawaves.wordpress.com/
 * https://alphagammawaves.wordpress.com/reader1/
 * Please go there if you have any comments or suggestions
 * http://support.neurosky.com/kb/development-2/eeg-band-power-values-units-amplitudes-and-meaning
 * Mindwave Reader One is also Open Source
 */

/**
 * To run  Mindwave Reader One as a stand-alone program
 *
 * on Windows 7, double-click on
 *
 *  MindwaveReaderOne-1\ThinkGearNet\ThinkGearNetTest\bin\x86\Release\ThinkGearNetTest-File.exe
 */



using System;
using System.IO;
using System.IO.Ports;  
using System.Threading;  
using System.Windows.Forms;
using ThinkGearNET;

namespace ThinkGearNETTest
{
	public partial class Form1 : Form
	{
        // Start the BackgroundWorker.
        //    backgroundWorker1.RunWorkerAsync(); 

        private string folderName;

		private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

            folderName = Properties.Settings.Default.myFolder;
            if(folderName.Length > 0){         // if User picked save to folder, then it's name will load
                lblFolder.Text = folderName;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = true;
                btnFile.Enabled = true;
                btnStop.Enabled = true;
            }


 			foreach(string port in SerialPort.GetPortNames())
				//cboPort.Items.Add(port);            
			    //cboPort.SelectedIndex = 0;
                listBox1.Items.Add(port);
                listBox1.SelectedIndex = 0;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper = new ThinkGearWrapper();

			// setup the event
			_thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

			// connect to the device on the specified COM port at 57600 baud            
            if (!_thinkGearWrapper.Connect(listBox1.SelectedItem.ToString(), 57600, true))
                MessageBox.Show("Could not connect to headset.");
            //else groupBox1.Visible = true;

		}

		void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
		{
            
			// update the textbox and sleep for a tiny bit
			BeginInvoke(new MethodInvoker(delegate 
				{
					lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
                    lblAttention2.Text = "0" + e.ThinkGearState.Attention;
					lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
					txtState.Text = e.ThinkGearState.ToString();

                    // Added:

                    int num1 = Convert.ToInt32(lblAttention2.Text);
                    if (num1 > 0)
                    {
                        //groupBox1.Visible = false;     // of Attention is greater than 0 then the Connecting box becomes visible
                        btnConnect.Enabled = false;
                        lblConnected.Visible = true;
                    }

                    // Added:
                    if (lblStart.Text == "Start")
                    {
                        lblTime.Text = DateTime.Now.ToString("T");  // "T" is the format "12:12:22 PM"
                        //lblRaw.Text = + e.ThinkGearState.Raw + ",";
                        lblDelta.Text = e.ThinkGearState.Delta + ",";
                        lblTheta.Text = e.ThinkGearState.Theta + ",";
                        lblAlpha1.Text = e.ThinkGearState.Alpha1 + ",";
                        lblAlpha2.Text = e.ThinkGearState.Alpha2 + ",";
                        lblBeta1.Text = e.ThinkGearState.Beta1 + ",";
                        lblBeta2.Text = e.ThinkGearState.Beta2 + ",";
                        lblGamma1.Text = e.ThinkGearState.Gamma1 + ",";
                        lblGamma2.Text = e.ThinkGearState.Gamma2 + ",";
                        //lblBlink.Text = e.ThinkGearState.BlinkStrength + ",";

                        string strWrite = (lblTime.Text + "," + lblDelta.Text + lblTheta.Text
                            + lblAlpha1.Text + lblAlpha2.Text + lblBeta1.Text + lblBeta2.Text
                            + lblGamma1.Text + lblGamma2.Text + "\n");  // "\n" tells it to go to a new line

                        string myProgram = Environment.CurrentDirectory;  // Directory (folder) of current program 

                        string myFile = folderName + "\\Mindwave.csv";                        
                        
                        //Create the file, and append info

                        System.IO.File.AppendAllText(myFile, strWrite);


                    }
                    //

				}));
			//Thread.Sleep(10);    // (100 lines per second)
            Thread.Sleep(1000);   // one line per second
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_thinkGearWrapper.Disconnect();

            Properties.Settings.Default.myFolder = folderName;
            Properties.Settings.Default.Save();    // Save the folder that the user picked for next time

		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.Disconnect();
            lblConnected.Visible = false;
            btnConnect.Enabled = true;
            //groupBox1.Visible = false;
		}

		private void btnEnableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(true);
		}

		private void btnDisableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(false);
		}

        private void btnFile_Click(object sender, EventArgs e)
        {

            //string myDirectory = folderName;  // the folder picked by the user


            if (!Directory.Exists(folderName))   // if \MyDocuments\Mindwave\ does not exist
            {
                MessageBox.Show(folderName + " does not exist! \n" + 
                                "Please click on the button \n " +
                                "Pick Folder to Save File To");
               // Directory.CreateDirectory(folderName);  // then create \MyDocuments\Mindwave\
            }

            
            string myFile = folderName + "\\Mindwave.csv";  // can also use:  @"c:\temp\MyTest.txt";

            string strLabels = "Time,Delta,Theta,Alpha1,Alpha2,Beta1,Beta2,Gamma1,Gamma2," + "\n";

            //System.IO.File.Open(myPath1, FileMode.Create);

            File.WriteAllText(myFile, strLabels);

            //System.IO.File.WriteAllLines("test);    //(myPath1, FileMode.Create);

            // Delete the file Mindwave.txt if it exists. 
            //if (File.Exists(pathTemp))
            //{
            //    File.Delete(pathTemp);
            //}


            lblStart.Text = "Start";
 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            lblStart.Text = "Stop";
            
            System.Diagnostics.Process.Start("explorer.exe", folderName);
                        
           // MessageBox.Show("Done");           

        }

        private void btnPick_Click(object sender, EventArgs e)
        {

            // https://msdn.microsoft.com/en-us/library/system.windows.forms.folderbrowserdialog.aspx

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                lblFolder.Text = folderName;
            }

            if (folderName.Length > 0)     // If folder has been picked then buttons are enabled
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = true;
                btnFile.Enabled = true;
                btnStop.Enabled = true;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Form2 class
            About settingsForm = new About();

            // Show the settings form
            settingsForm.Show();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Form2 class
            Help settingsForm = new Help();

            // Show the settings form
            settingsForm.Show();



        }
	}
}
