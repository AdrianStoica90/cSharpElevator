using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Elevator
{

    public partial class Form1 : Form
    {   
        /// <summary>
        /// Declaration and Instantiation of all needed components - START
        /// </summary>
        /// 

        //
        //DataSet
        //
        public static string myEvent; // the event string that will be saved into the database.
        public static bool populated; // this variable will check if the dataset is populated
        public static DataSet myData; // this is the dataset which will hold all events (old from the database and new from the GUI).

        //
        //Database components declaration
        //
        public static string connectionString;
        public static string commandString;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;

        /// <summary>
        /// Declaration finished
        /// </summary>


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            //Instantiation
            //
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataLogs.accdb;";
            commandString = "SELECT * FROM Logs;";
            conn = new OleDbConnection(connectionString);
            comm = new OleDbCommand(commandString, conn);
            adapter = new OleDbDataAdapter(comm);
            myData = new DataSet();
            builder = new OleDbCommandBuilder(adapter);
            builder.QuotePrefix = "["; //Needed by the builder to build the statements for the adaptor
            builder.QuoteSuffix = "]"; 
            progressBar2.Value = 0;
            progressBar2.Maximum = 100;
            GetData(); // retrieve any data that might be present in the database and fill the dataSet
            PopulateListBox(); //Populate the listbox using the data from the dataset

        }


        /// <summary>
        /// Functions for handling the data between the GUI, Database and the dataset
        /// </summary>
        /// 

        //Function that retrieves data from the database and adds it into the dataset
        public void GetData()
        {
            try
            {
                conn.Open(); //open connection
                myData.Clear(); // clear any data from the dataset
                adapter.Fill(myData); // adapter gets data from the database and adds it into the dataset
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // display any error that might occur.
            }
            conn.Close(); // close connection with the database
            
        }

        //Function to update the database
        public void UpdateDatabase()
        {
            if (myData.Tables[0].Rows.Count != 0) // check if the dataset has any data into it
            {
                try
                {
                    conn.Open();
                    DataSet newDataSet = myData.GetChanges(); // create new dataset that takes any changes occured into the primary dataset
                    adapter.Update(newDataSet); //adapter takes the new dataset with the new changes and updates the data into the database.
                    myData.Tables[0].AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " " + ex.Source.ToString());
                }
                conn.Close();
            }
        }

        //Function that will load the data from the dataset into the listBox
        public void PopulateListBox()
        {

            {
                listBox1.Items.Clear(); //clear any data from the Listbox
                foreach (DataRow row in myData.Tables[0].Rows) // loop through the dataset and add data into the listbox
                {
                    listBox1.Items.Add(row["Time"] + " " + row["Date"] + " =>> " + row["Event"]);
                }
            }

        }


        //Function that updates the dataset with new events
        public void UpdateDataset(string myEvent)
        {
            
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();


            
            DataRow newRow = myData.Tables[0].NewRow(); //defining a new row of the same type as our dataset

            newRow["Time"] = time; //add data into the new row
            newRow["Date"] = date;
            newRow["Event"] = myEvent;

            
            myData.Tables[0].Rows.Add(newRow); //add the new DataRow to the dataset 
            PopulateListBox();
        }

        /// <summary>
        /// Functions for actioning the elevator
        /// </summary>
        /// 

        //Function called by the buttons: FirstFloorBtn and FRequestBtn
        public void Go_Up() 
        {
            UpdateDataset("Closing Doors at Ground Floor"); //update dataset with new event
            CloseDown.Enabled = true; //activate the CloseDown timer which closes the doors at ground floor
            GroundDisplay.Text = "G"; //Sets the display
            PanelDisplay.Text = "G"; //Sets the display
            FirstDisplay.Text = "G"; //Sets the display
        }
        //Function called by the buttons: GroundFloorBtn and GRequestBtn
        public void Go_Down()
        {
            UpdateDataset("Closing Doors at First Floor"); //Update dataset with new data;
            CloseUp.Enabled = true; //activates the timer which closes the doors at first floor
            GroundDisplay.Text = "1"; //Sets the display
            PanelDisplay.Text = "1"; //Sets the display
            FirstDisplay.Text = "1"; //Sets the display


        }


        //Function of the timer which opens the doors at the ground floor
        private void OpenDown_Tick(object sender, EventArgs e)
        {
            if (InLeft.Size.Width > 0) //checks the width of the doors (when this if statement is true  => doors are open)
            {
                
                InLeft.Size = new Size(InLeft.Size.Width - 5, InLeft.Height); //Sets new size of the inside left door
                InRight.Size = new Size(InRight.Size.Width - 5, InRight.Height); //Sets new size of the inside right door
                InRight.Location = new Point(InRight.Location.X + 5, InRight.Location.Y); //Sets new location of the inside right door 
                //open outside doors from ground floor
                OutLG.Size = new Size(OutLG.Width - 5, OutLG.Height); //Sets new size of the outside left ground floor door
                OutRG.Size = new Size(OutRG.Width - 5, OutRG.Height); //Sets new size of the outside right ground floor door
                OutRG.Location = new Point(OutRG.Location.X + 5, OutRG.Location.Y); //Sets new location of the  right ground floor door
            }
            else
            {
                backgroundWorker1.RunWorkerAsync(); //calls the background worker which calls other functions on a different thread
                OpenDown.Enabled = false; //deactivate the openDown timer
                FRequestBtn.Enabled = true; //Enable buttons
                FirstFloorBtn.Enabled = true; //Enable buttons
                GRequestBtn.BackColor = Color.White; //Reset button color
                GroundFloorBtn.BackColor = Color.White; //Reset button color
            }
        }


        //Function of the timer which opens the doors at the first floor
        private void OpenUp_Tick(object sender, EventArgs e)
        {
            if (InLeft.Size.Width > 0) //if this if statement is true then the doors are closed
            {
                //set new size and location of the inside doors and outside first floor doors
                InLeft.Size = new Size(InLeft.Size.Width - 5, InLeft.Height);
                InRight.Size = new Size(InRight.Size.Width - 5, InRight.Height);
                InRight.Location = new Point(InRight.Location.X + 5, InRight.Location.Y);
                OutLF.Size = new Size(OutLF.Width - 5, OutLF.Height);
                OutRF.Size = new Size(OutRF.Width - 5, OutRF.Height);
                OutRF.Location = new Point(OutRF.Location.X + 5, OutRF.Location.Y);
            }
            else
            {
                UpdateDatabase();
                OpenUp.Enabled = false;
                GRequestBtn.Enabled = true;
                GroundFloorBtn.Enabled = true;
                FRequestBtn.BackColor = Color.White;
                FirstFloorBtn.BackColor = Color.White;
            }
        }
        

        //Function of the timer which closes the doors at ground floor
        private void CloseDown_Tick(object sender, EventArgs e)
        {
            if (InLeft.Size.Width < 71)
            {
                InLeft.Size = new Size(InLeft.Size.Width + 5, InLeft.Height);
                InRight.Size = new Size(InRight.Size.Width + 5, InRight.Height);
                InRight.Location = new Point(InRight.Location.X - 5, InRight.Location.Y);
                OutLG.Size = new Size(OutLG.Width + 5, OutLG.Height);
                OutRG.Size = new Size(OutRG.Width + 5, OutRG.Height);
                OutRG.Location = new Point(OutRG.Location.X - 5, OutRG.Location.Y);
            }
            else
            {
                UpdateDataset("Going Up");
                CloseDown.Enabled = false;
                GroundDisplay.Text = "↑";
                PanelDisplay.Text = "↑";
                FirstDisplay.Text = "↑";
                GoUpTimer.Enabled = true;
            }
        }


        //Function of the timer that closes the doors at the first floor
        private void CloseUp_Tick(object sender, EventArgs e)
        {
            
            if (InLeft.Size.Width < 71)
            {
                InLeft.Size = new Size(InLeft.Size.Width + 5, InLeft.Height);
                InRight.Size = new Size(InRight.Size.Width + 5, InRight.Height);
                InRight.Location = new Point(InRight.Location.X - 5, InRight.Location.Y);
                OutLF.Size = new Size(OutLF.Width + 5, OutLF.Height);
                OutRF.Size = new Size(OutRF.Width + 5, OutRF.Height);
                OutRF.Location = new Point(OutRF.Location.X - 5, OutRF.Location.Y);
            }
            else
            {

                UpdateDataset("Going Down");
                CloseUp.Enabled = false;
                GoDownTimer.Enabled = true;
                GroundDisplay.Text = "↓";
                PanelDisplay.Text = "↓";
                FirstDisplay.Text = "↓";
            }
        }


        //Function of the timer that makes the lift and inside doors to go down
        private void GoDownTimer_Tick(object sender, EventArgs e)
        {
            if (Elevator.Location.Y < 213)
            {
                Elevator.Top += 4; //moves elevator down by 4 pixels on each iteration
                InLeft.Top += 4; //moves inside left door down by 4 pixels on each iteration
                InRight.Top += 4; //moves inside right door down by 4 pixels on each iteration
            }
            else
            {
                GoDownTimer.Stop(); 
                UpdateDataset("Opening Door at Ground Floor"); //Updates the dataset with new event
                OpenDown.Enabled = true;
                GroundDisplay.Text = "G";
                PanelDisplay.Text = "G";
                FirstDisplay.Text = "G";
            }
        }


        //FUnction of the timer that makes the lift and inside doors to go up
        private void GoUpTimer_Tick(object sender, EventArgs e)
        {
            
                if (Elevator.Location.Y > 33)
                {
                    Elevator.Top -= 4;
                    InLeft.Top -= 4;
                    InRight.Top -= 4;
                }
                else
                {
                    GoUpTimer.Stop();
                    UpdateDataset("Opening Door at First Floor");
                    GroundDisplay.Text = "1";
                    PanelDisplay.Text = "1";
                    FirstDisplay.Text = "1";
                    OpenUp.Enabled = true;
                    
                }
        }


        //Function called by clicking the first floor request button
        private void FRequestBtn_Click(object sender, EventArgs e)
        {
            FRequestBtn.BackColor = Color.DarkOrange; //highlight the button to show that it was clicked
            //Disable all other buttons to avoid conflicting commands
            FRequestBtn.Enabled = false;
            FirstFloorBtn.Enabled = false;
            GRequestBtn.Enabled = false;
            GroundFloorBtn.Enabled = false;

            Go_Up(); //call the Go_Up function
        }


        //Function called by clicking the first floor button from the control panel inside of the elevator.
        private void FirstFloorBtn_Click(object sender, EventArgs e)
        {
            FirstFloorBtn.BackColor = Color.DarkOrange;
            FRequestBtn.Enabled = false;
            FirstFloorBtn.Enabled = false;
            GRequestBtn.Enabled = false;
            GroundFloorBtn.Enabled = false;
            Go_Up();
        }


        //Function called by clicking the ground floor request button
        private void GRequestBtn_Click(object sender, EventArgs e)
        {
            GRequestBtn.BackColor = Color.DarkOrange;
            FRequestBtn.Enabled = false;
            FirstFloorBtn.Enabled = false;
            GRequestBtn.Enabled = false;
            GroundFloorBtn.Enabled = false;
            Go_Down();
        }

        //Function called by clicking the ground floor button from the control panel inside of the elevator.
        private void GroundFloorBtn_Click(object sender, EventArgs e)
        {
            GroundFloorBtn.BackColor = Color.DarkOrange;
            FRequestBtn.Enabled = false;
            FirstFloorBtn.Enabled = false;
            GRequestBtn.Enabled = false;
            GroundFloorBtn.Enabled = false;
            Go_Down();
        }


        //Function that displays the logs data into the listbox
        private void ShowLogs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //clear any data from the listbox
            GetData(); //get data from database and add it into the dataset
            PopulateListBox(); //update listbox using newly updated dataset
        }


        //Button that clears any data from the listbox
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //Function of the background worked that updates the database and the progress bar
        //This function runs the functions on a different thread than the UI thread
        //This makes the GUI more responsive and robust
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateDatabase();
            for(int i = 1; i<100; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }
        }

        
        //Function of the backgoundworker that changes the value of the progressbar on each iteration
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }



        //Function of the backgroundworker that resets the value of the progressbar to 0 when the backgroundworker completes a task
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.Value = 0;
        }
    }
}





