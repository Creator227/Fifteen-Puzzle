using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Пятнашки
{
    public partial class PuzzleForm : Form
    {
        GameController gameController;
        public string player = "Player";
        private int time;
        private DateTime startTime;
        List<GameResult> userData;
        XmlSerializer formatter;
        string filename;
        public PuzzleForm()
        {
            InitializeComponent();
        }

        private void _15_4on4_Load(object sender, EventArgs e)
        {
            userData = new List<GameResult>(10);
            formatter = new XmlSerializer(typeof(List<GameResult>));

            switch (MainMenu.GameSize)
            {
                case 3:
                    filename = "ThreePuzzleData.xml";
                    break;
                case 4:
                    filename = "FourPuzzleData.xml";
                    break;
                case 5:
                    filename = "FivePuzzleData.xml";
                    break;             
            }

            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                if (fs.Length > 0)
                {
                    userData = (List<GameResult>)formatter.Deserialize(fs);
                }
            }

            dataGridViewGame.ColumnCount = MainMenu.GameSize;
            dataGridViewGame.RowCount = MainMenu.GameSize;

            for (int i = 0; i < MainMenu.GameSize; i++)
            {
                dataGridViewGame.Columns[i].Width = dataGridViewGame.Width / MainMenu.GameSize - 1;
                dataGridViewGame.Rows[i].Height = dataGridViewGame.Height / MainMenu.GameSize - 1;
            }

            StartGame();
        }
  
        private void StartGame()
        {
            gameController = new GameController(MainMenu.GameSize);
            ShowPuzzle();
            time = 0;
            startTime = DateTime.Now;
            timer1.Start();
        }
        private void ShowPuzzle()
        {
            for (int i = 0; i < MainMenu.GameSize * MainMenu.GameSize; i++)
            {
                int row = i / MainMenu.GameSize;
                int cell = i - row * MainMenu.GameSize;

                dataGridViewGame.Rows[row].Cells[cell].Value =
                    (gameController.Puzzle[i] != 0) ? (gameController.Puzzle[i].ToString()) : "";

                dataGridViewGame.Rows[row].Cells[cell].Selected = false;
            }
            lbSteps.Text = "Шаги: " + gameController.Steps.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGame_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex * MainMenu.GameSize + e.ColumnIndex;
            gameController.MoveBlock(pos);
            ShowPuzzle();
            if (gameController.IsFinished())
            {
    
                dataGridViewGame.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Вы выйграли! Количество шагов: " + gameController.Steps
                    + ". Время: " + time.ToString());

                userData.Add(new GameResult(player, startTime, time, gameController.Steps));
                userData.Sort((x, y) => (x.BeginTime).CompareTo(y.BeginTime));

            }
        }

        private void lbSteps_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            lbTime.Text = "Время: " + time.ToString(); 
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTime.Text = "Время: 0"; 
            timer1.Stop();
            dataGridViewGame.Enabled = true;
            StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            player = TBPlayer.Text;
        }

        // Часть Serialize
        private void BLastResults_Click(object sender, EventArgs e)
        {
            string results = "";
            var dataToDisplay = (userData.Count > 10) ? userData.GetRange(userData.Count - 10, 10) : userData;
            foreach (var item in dataToDisplay)
            {


                results += String.Format("Время начала сборки:{0}, имя игрока: {1}, шаги: {2}, время: {3} sec\n",
                item.BeginTime, item.Player, item.StepNumber, item.CollectTime);
            }

            MessageBox.Show(results);
        }

        private void BBestSteps_Click(object sender, EventArgs e)
        {
            List<GameResult> userDataBS = userData;
            userDataBS.Sort((x, y) => x.StepNumber.CompareTo(y.StepNumber));
            string results = "";
            var dataToDisplay = (userDataBS.Count > 10) ? userDataBS.GetRange(userData.Count - 10, 10) : userDataBS;
            foreach (var item in dataToDisplay)
            {
                results += String.Format("Время начала сборки:{0}, имя игрока: {1}, шаги: {2}, время: {3} sec\n",
                item.BeginTime, item.Player, item.StepNumber, item.CollectTime);
            }

            MessageBox.Show(results);
        }

        private void BBestTime_Click(object sender, EventArgs e)
        {
            List<GameResult> userDataBT = userData;
            userDataBT.Sort((x, y) => x.CollectTime.CompareTo(y.CollectTime));
            string results = "";
            var dataToDisplay = (userDataBT.Count > 10) ? userDataBT.GetRange(userData.Count - 10, 10) : userDataBT;
            foreach (var item in dataToDisplay)
            {
                results += String.Format("Время начала сборки:{0}, имя игрока: {1}, шаги: {2}, время: {3} sec\n",
                item.BeginTime, item.Player, item.StepNumber, item.CollectTime);
            }

            MessageBox.Show(results);
        }

        private void PuzzleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, userData);
            }
            MessageBox.Show("Спасибо за игру!\n Результаты были сохранены.");
        }

        private void BDeleteResults_Click(object sender, EventArgs e)
        {
            userData.RemoveAll(x => (x.BeginTime <= dateTimePicker.Value));
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
