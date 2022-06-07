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
using System.Media;

namespace Adventure_Guild {

    public partial class StartWindow : Form {

        private Dictionary<string, List<string>> allQuest;
        private List<string> firstNames;
        private List<string> lastNames;

        public StartWindow() {
            InitializeComponent();
            GetAllQuest();
            firstNames = GetNames(Path.GetFullPath("data/firstnames.txt"));
            lastNames = GetNames(Path.GetFullPath("data/lastnames.txt"));
            this.FormClosed += quitBtn_Click;
        }

        #region Button Click Events
            private void startBtn_Click(object sender, EventArgs e) {
                GuildFrm frm = new GuildFrm(allQuest, firstNames, lastNames);
                SoundPlayer startSound = new SoundPlayer(Path.GetFullPath("sounds/uprising3.wav"));
                startSound.Play();
                frm.Show();
                this.Hide();
            } // Start the program
            private void quitBtn_Click(object sender, EventArgs e) {
                Application.Exit();
            } // Quit the program
        #endregion

        #region Helper Methods
            private void GetAllQuest() {
                StreamReader questFile = new StreamReader(Path.GetFullPath("data/questInfo.txt"));
                allQuest = new Dictionary<string, List<string>>();
                while (!questFile.EndOfStream) {
                    // Get Quest's Name and Possible Ranks
                    List<string> data = questFile.ReadLine().Split().ToList(); // EX: (Quest_Name RANK RANK RANK)
                    string questname = data[0];
                    data.Remove(questname);
                    allQuest.Add(questname, data);
                }
            } // Get quests from a file
            private List<string> GetNames(string namePath) {
                StreamReader nameFile = new StreamReader(Path.GetFullPath(namePath));
                List<string> names = new List<string>();
                while(!nameFile.EndOfStream) {
                    names.Add(nameFile.ReadLine());
                }
                return names;
            } // Get names in a file of names
        #endregion
    }
}
