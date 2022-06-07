using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Globalization;
using System.Linq;

namespace Adventure_Guild {
    public partial class GuildFrm : Form {

        private string selectedAdventurer;
        private Dictionary<string, List<string>> questOptions;
        private List<string> firstnameList;
        private List<string> lastnameList;

        private string savesPath = Path.GetFullPath("saves");
        private Adventurer ourAdventurer = null;
        private Guild ourGuild = null;
        private SoundPlayer mySound = new SoundPlayer(Path.GetFullPath("sounds/hard-button.wav"));

        public GuildFrm(Dictionary<string, List<string>> quests, List<string> firstnames, List<string> lastnames) {
            InitializeComponent();
            questOptions = quests;
            firstnameList = firstnames;
            lastnameList = lastnames;

            if (Directory.Exists(savesPath)) {
                LoadAventerurersBtns();
            } else {
                Directory.CreateDirectory(savesPath);
            }

            ChangePanelSizesAndLocation();
            this.FormClosed += stopProgram;
        }

        #region Button Clicked Events
            #region Create Screen
                private void backBtn_Click(object sender, EventArgs e) {
                    StartWindow frm = new StartWindow();
                    frm.Show();
                    this.Hide();
                }   // Back to Form 1
                private void createBtn_Click(object sender, EventArgs e) {
                    DeselectAdventurer();
                    ChangeAdventurerBtnActivation(false);   // Reset adventurer's button color
                    HidePanelElements(newAdventurerPanel);
                    HidePanelElements(createBackPnl);
                    ShowCreateNewAdventurer();              // Controls for add new adventurer
                    cancelBtn.Visible = true;               // Display cancel button
                } // Show controls to add new Adventurer
                private void createAdventurerBtn_Click(object sender, EventArgs e) {
                    if (ValidUserName(usernameTxt.Text)) { return; } // Valid user's name

                    // Capitalize the First Letter of each word
                    string username = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(usernameTxt.Text.ToLower());

                    // Create a directory with the user's name to save all their data to
                    string dirName = ReplaceSpaces(username);
                    Directory.CreateDirectory(savesPath + $"/{dirName}");
                    StreamWriter file = new StreamWriter(savesPath + $"/{dirName}/data.txt");
                    file.WriteLine("RANK_E");
                    file.WriteLine("COINS_50");
                    file.Close();

                    cancelBtn_Click(sender, e);
                    ClearAdventurerBtns();       // Remove Adventurer's buttons
                    LoadAventerurersBtns();      // Add Adventurer buttons
                } // Create a new adventurer
                private void cancelBtn_Click(object sender, EventArgs e) {
                    ChangeAdventurerBtnActivation(true);  // Allow adventurer's button to be clicked
                    HidePanelElements(newAdventurerPanel);
                    HidePanelElements(createBackPnl);
                    startWorldBtn.Visible = true;       // Show enter world button
                    createBtn.Visible = true;           // Show create adventurer button
                    backBtn.Visible = true;             // Show back button
                    usernameTxt.Text = "";              // Reset username text box
                } // Go back to being able to select adventurer
                private void SelectAdventure(object sender, EventArgs e) {
                    mySound.Play();
                    selectedAdventurer = "";    // Reset selected adventurer
                    foreach (Control control in adventurerPanel.Controls) {
                        if (control.GetType() == typeof(Button)) {
                            // Reset all button colors
                            control.BackColor = SystemColors.ControlLight;
                        }

                        // Get selected adventurer and change their color to show that they have been selected
                        if(sender == control) {
                            control.BackColor = Color.DarkGray;
                            selectedAdventurer = control.Text.Split("\n")[0];
                        }
                    }

                    startWorldBtn.Enabled = true;
                } // Select the adventurer the user wants to use
                private void startWorldBtn_Click(object sender, EventArgs e) {
                    HideAllCreateMenuPanels();
                    ShowAllPlayPanels();
                    LoadUserAdventurer();
                    // Update Labels
                    DisplayAdventurerInfo();
                    DisplayGuildInfo();
                } // Start the World
            #endregion

            #region Play Screen
                private void logoutBtn_Click(object sender, EventArgs e) {
                    HideAllPlayPanels();
                    ShowAllCreateMenuPanels();
                    DeselectAdventurer();
                    Save();
                } // Save adventurer data to file and go back to create screen
                private void bonusBtn_Click(object sender, EventArgs e) {
                    bonusesPnl.Visible = !bonusesPnl.Visible;
                }  // Toggle our bonus buttons
                private void GetQuest(object sender, EventArgs e) {
                    // Send quest name to guild then determine which quest to send back
                    string questName = ((Button)sender).Text.Split("\n")[0];
                    Quest quest = ourGuild.FindQuest(questName);
                    if (quest == null) { return; }

                    // Determine if adventurer can do quest
                    if (!CanDoQuest(ourAdventurer, quest.GetQuestRank())) {
                        MessageBox.Show("You are to low rank to do this quest.");
                        return;
                    }

                    // See if the adventurer wants to continue the quest with min supplies
                    if (ourAdventurer.GetCoins() - quest.GetCostOfSupplies() < 0) { 
                        DialogResult dialogResult = MessageBox.Show("You don't have enought coins to get all of the supplies. Do you still want " +
                                "to do this quest.", "Do Quest", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No) {
                            return;
                        }
                    }

                    // Do Quest
                    string currentRank = ourAdventurer.GetRank();
                    GoOnQuest(ourAdventurer, quest);
                    DisplayAdventurerInfo();
                    if (currentRank != ourAdventurer.GetRank()) {
                        MessageBox.Show($"Rank {ourAdventurer.GetRank()}\nYOU RANKED UP!!!");
                    }
                } // Get a quest to do
            #endregion

            #region Guild Bonues Buttons
                private void moreMoneyBtn_Click(object sender, EventArgs e) {
                    int bonus = ourGuild.GiveBonusCoins(ourAdventurer);
                    MessageBox.Show($"You earned {bonus} coins from the guilds profit this month.");
                    moreMoneyBtn.Enabled = false;
                    ourAdventurer.SetCoins(ourAdventurer.GetCoins() + bonus);
                    coinsLbl.Text = $"COINS: {ourAdventurer.GetCoins()}";
                    profitLbl.Text = $"COINS: {ourGuild.GetCoins()}";
                }  // Display coin bonues
                private void lotteryBtn_Click(object sender, EventArgs e) {
                    string msg = ourGuild.PlayLottery();
                    MessageBox.Show(msg);
                    lotteryBtn.Enabled = false;
                    profitLbl.Text = $"COINS: {ourGuild.GetCoins()}";
                }    // Display result of Lottery
                private void freeInnBtn_Click(object sender, EventArgs e) {
                    int numberofInnTickets = ourGuild.GiveFreeInnTickets(ourAdventurer);
                    MessageBox.Show($"You earned {numberofInnTickets} free nights at the inn");
                    freeInnBtn.Enabled = false;
                    profitLbl.Text = $"COINS: {ourGuild.GetCoins()}";
                }    // Display Free Inn Msg
            #endregion

            private void GuildFrm_Load(object sender, EventArgs e) {

            }   // Run when guild Loads
            private void stopProgram(object sender, EventArgs e) {

                if (ourAdventurer != null) { Save(); }
                Application.Exit();
            }     // Close the program
        #endregion

        #region Helper Methods
            #region Format from/to files
                private string ReplaceSpaces(string name) {
                // Combine the string using underscore to make it easier to get data from a file
                string str = name;

                if (str.Split().Length != 1) {
                    str = str.Replace(" ", "_");
                }

                return str;
            }       // Replace all spaces with underscores
                private string ReplaceUnderscores(string name) {
                // Read remove underscore from name
                string str = name.Replace("_", " ");
                return str;
            }  // Replace all underscores with spaces
        #endregion

            #region Adventurer
                private void DeselectAdventurer() {
                    if (selectedAdventurer == "") { return; }
                    foreach (Control control in adventurerPanel.Controls) {
                        if (control.GetType() == typeof(Button)) {
                            // Reset all button colors
                            control.BackColor = SystemColors.ControlLight;
                        }
                    }
                    selectedAdventurer = "";
                    startWorldBtn.Enabled = false;
                }   // Deselect adventurer if one is selected
                private void ChangeAdventurerBtnActivation(bool isActive) {
                    foreach (Control control in adventurerPanel.Controls) {
                        if (control.GetType() == typeof(Button)) {
                            // Reset all button colors
                            control.Enabled = isActive;
                        }
                    }
                } // Enable / Disable adventurer's buttons
                private void AdventerurerBtn(string name, string rank, int currentLine) {
                    Button btn = new Button();
                    btn.Size = new Size(157, 50);
                    btn.Location = new Point(19, 42 + (currentLine * 55));
                    btn.Font = new Font("Bodoni MT", 10);
                    btn.Text = $"{ReplaceUnderscores(name)}\n{rank}";
                    btn.Click += SelectAdventure;
                    btn.BackColor = SystemColors.ControlLight;
                    btn.TabStop = false;
                    adventurerPanel.Controls.Add(btn);
                } // Build Adventurer button
                private string GeneratorName() {
                    int firstIndex = new Random().Next(0, firstnameList.Count);
                    int lastIndex = new Random().Next(0, lastnameList.Count);
                    return $"{firstnameList[firstIndex]} {lastnameList[lastIndex]}";
                } // Name gernerator
                private bool CanDoQuest(Adventurer adventurer, string questRank) {
                    string ourRank = adventurer.GetRank();
                    int rankDifference = Guild.GetRankValue(ourRank) - Guild.GetRankValue(questRank);
                    if (rankDifference < -1) { return false; }
                    return true;
                } // Check if rank is high enough to do quest
                private void GoOnQuest(Adventurer adventurer, Quest quest) {
                    adventurer.DoQuest(quest);
                    if (!adventurer.GetLastQuestCompletion()) { return; }

                    ourGuild.RemoveQuest(quest);
                    if (ourGuild.GetQuests().Count < 6 || !CanDoAQuest()) {
                        DisplayNewQuest();
                    } else {
                        DisplayGuildInfo();
                    }
                } // Adventurer will do quest
            #endregion

            #region Guild
                private string GetRandomQuest() {
                    int randIndex = new Random().Next(0, questOptions.Count);
                    return questOptions.ElementAt(randIndex).Key;
                } // Get a random quest from our options
                private bool IsUniqueQuest(string questName) {
                    Quest foundQuest = ourGuild.FindQuest(questName);
                    if (foundQuest != null) { return false; }

                    return true;
                }  // Find out if already have a quest with name given
                private string GetRandomQuestRank(string questname) {
                    int randRank = new Random().Next(0, questOptions[questname].Count);
                    return questOptions[questname][randRank];
                } // Pick a random rank from quest options
                private void AddQuest() {
                    string questname = GetRandomQuest();
                    while(!IsUniqueQuest(ReplaceUnderscores(questname))) {
                        questname = GetRandomQuest();
                    }
                    string rank = GetRank(GetRandomQuestRank(questname));
                    Quest newQuest = new Quest(ReplaceUnderscores(questname), rank);
                    ourGuild.GetNewQuest(newQuest);
                } // Add new Quest to guild
                private void GenarateQuests(int maxNumOfQuests) {
                    int minQuest = maxNumOfQuests - 3;
                    if(minQuest < 1) { minQuest = 1; }
                    int numberOfQuestToGenarate = new Random().Next(minQuest - 3, maxNumOfQuests);
                    while (numberOfQuestToGenarate > 0) {
                        AddQuest();
                        numberOfQuestToGenarate--;
                    }
                    if(!CanDoAQuest()) { ResetQuests(); }
                } // Genarates a random number of quest basic on many already have
                private bool CanDoAQuest() {
                    foreach (Quest quest in ourGuild.GetQuests()) {
                        if (CanDoQuest(ourAdventurer, quest.GetQuestRank())) { return true; }
                    }
                    return false;
                } // Check if our adventurer can do any of the quest on the quest board
                private void ResetQuests() {
                    ourGuild.GetQuests().Clear();
                    DisplayNewQuest();
                } // Reset the Quest List
            #endregion

            private bool ValidUserName(string username) {
                nameLbl.Focus();
                if (username.Contains("_")) {
                    MessageBox.Show("Username can not contain any underscores(_).");
                    return true;
                } else if (username == "") {
                    MessageBox.Show("Can't Sumbit name");
                    return true;
                } else if (username.Length > 23) {
                    MessageBox.Show("Can't have more than 18 characters in your name.");
                    return true;
                } else if (Directory.Exists(savesPath + "/" + ReplaceSpaces(username))) {
                    MessageBox.Show("Name is take. Please make a new name.");
                    return true;
                }

                return false;
            } // Get a valid username
            private string GetRank(string data) {
                string rank = ReplaceUnderscores(data);
                return rank.Split()[1];
            } // Get the rank of Adventurer/Guild/Quest from file data
            private int GetCoins(string data) {
                string coins = ReplaceUnderscores(data);
                return int.Parse(coins.Split()[1]);
        } // Get the coins of Adventurer/Guild/Quest from file data
            private float GetDifficultly(string data) {
                string difficultly = ReplaceUnderscores(data);
                return float.Parse(difficultly.Split()[1]);
        } // Get the quest difficultly from file data
            private List<string> OpenFile(string path) {
                StreamReader file = new StreamReader(path);
                List<string> data = new List<string>();
                while (!file.EndOfStream) {
                    data.Add(file.ReadLine());
                }
                file.Close();
                return data;
            } // Get Data for file
            private void ChangePanelSizesAndLocation() {
                // Change The panel Location and Size
                // Adventurer Panel
                adventurerPanel.Location = new Point(12, 57);
                adventurerPanel.Size = new Size(200, 477);
                // newAdventurerPanel
                newAdventurerPanel.Location = new Point(366, 434);
                newAdventurerPanel.Size = new Size(216, 100);
                // createBackPnl
                createBackPnl.Location = new Point(706,464);
                createBackPnl.Size = new Size(166,85);
                // adventurerInfoPnl
                adventurerInfoPnl.Location = new Point(0, 12);
                adventurerInfoPnl.Size = new Size(200, 126);
                // bonusesPnl
                bonusesPnl.Location = new Point(12, 181);
                bonusesPnl.Size = new Size(136, 160);
                // actionPnl
                actionPnl.Location = new Point(12, 363);
                actionPnl.Size = new Size(194, 187);
                // questBoardPnl
                questBoardPnl.Location = new Point(208, 79);
                questBoardPnl.Size = new Size(472, 383);
                // guildInfoPnl
                guildInfoPnl.Location = new Point(688, 12);
                guildInfoPnl.Size = new Size(186, 109);
                // logoutPnl
                logoutPnl.Location = new Point(688, 493);
                logoutPnl.Size = new Size(194, 56);
            } // Positon the Panel where they were meant to be

            #region Clear
                private void ClearAdventurerBtns() {
                    foreach(Control btn in adventurerPanel.Controls) {
                        if(typeof(Button) == btn.GetType()) {
                            adventurerPanel.Controls.Remove(btn);
                        }
                    }
                } // Remove Adventurer buttons
                private void ClearQuestBoard() {
                    foreach (Button questBtn in questBoardPnl.Controls.OfType<Button>().ToList()) {
                        questBoardPnl.Controls.Remove(questBtn);
                    }
                } // Remove Quest Board's Quest buttons
            #endregion

            #region Display info
                private void DisplayAdventurerInfo() {
                    adventurerNameLbl.Text = ourAdventurer.GetName();
                    rankLbl.Text = $"RANK {ourAdventurer.GetRank()}";
                    coinsLbl.Text = $"COINS: {ourAdventurer.GetCoins()}";
                }
                private void DisplayGuildInfo() {
                    profitLbl.Text = $"COINS: {ourGuild.GetCoins()}";
                    DisplayQuestBoardBtns(ourGuild.GetQuests());
                }
                private void DisplayQuestBoardBtns(List<Quest> guildQuests) {
                    ClearQuestBoard();
                    Point location = new Point(8, 73);
                    for (int i = 0; i < guildQuests.Count; i++) {
                        // Find Location
                        location.X = 8 + (152 * (i % 3));
                        if (i % 3 == 0 && i != 0) { location.Y += 71; }
                        Button btn = new Button();
                        btn.Size = new Size(146, 65);
                        btn.Location = location;
                        btn.Font = new Font("Bodoni MT", 10);
                        btn.TabStop = false;
                        btn.BackColor = SystemColors.ControlLight;
                        btn.Click += GetQuest;
                        btn.Text = $"{guildQuests[i].GetQuestName()}\n" +
                            $"RANK {guildQuests[i].GetQuestRank()}\n" +
                            $"Reward: {guildQuests[i].GetQuestReward()}";
                        questBoardPnl.Controls.Add(btn);
                    }
                }
                private void DisplayNewQuest() {
                    int maxNumOfQuests = 12 - ourGuild.GetQuests().Count;
                    if (maxNumOfQuests == 0) { return; }
                    GenarateQuests(maxNumOfQuests);
                    DisplayGuildInfo();
                }
            #endregion

            #region Hide/Show Panels
                private void HideAllCreateMenuPanels() {
                    adventurerPanel.Visible = false;
                    createBackPnl.Visible = false;
                    newAdventurerPanel.Visible = false;
                }
                private void HidePanelElements(Panel panel) {
                    foreach (Control item in panel.Controls) {
                        item.Visible = false;
                    }
                }
                private void HideAllPlayPanels() {
                    adventurerInfoPnl.Visible = false;
                    bonusesPnl.Visible = false;
                    actionPnl.Visible = false;
                    questBoardPnl.Visible = false;
                    guildInfoPnl.Visible = false;
                    logoutPnl.Visible = false;
                }
                private void ShowAllCreateMenuPanels() {
                    adventurerPanel.Visible = true;
                    createBackPnl.Visible = true;
                    newAdventurerPanel.Visible = true;
                }
                private void ShowCreateNewAdventurer() {
                    usernameTxt.Visible = true;
                    nameLbl.Visible = true;
                    createAdventurerBtn.Visible = true;
                }
                private void ShowAllPlayPanels() {
                    adventurerInfoPnl.Visible = true;
                    actionPnl.Visible = true;
                    questBoardPnl.Visible = true;
                    guildInfoPnl.Visible = true;
                    logoutPnl.Visible = true;
                }
            #endregion
        #endregion

        #region Load / Save Files
            // Load Files
            private void LoadUserAdventurer() {
                // Load adventurer info
                List<string> data = OpenFile($"{savesPath}/{ReplaceSpaces(selectedAdventurer)}/data.txt");
                ourAdventurer = new Adventurer(selectedAdventurer, GetRank(data[0]), GetCoins(data[1]));
                // Adventurer's quests
                if(File.Exists($"{savesPath}/{ReplaceSpaces(selectedAdventurer)}/quests.txt")) {
                    data = OpenFile($"{savesPath}/{ReplaceSpaces(selectedAdventurer)}/quests.txt");
                    List<Quest> quests = new List<Quest>();
                    foreach(string questdata in data) {
                        Quest quest = LoadQuest(questdata);
                        string completed = ReplaceUnderscores(questdata.Split()[5]);
                        quest.SetQuestCompletion(bool.Parse(completed.Split()[1]));
                        quests.Add(quest);
                    }
                    ourAdventurer.SetQuestList(quests);
                }

                // Load Guild
                ourGuild = LoadGuild($"{savesPath}/{ReplaceSpaces(selectedAdventurer)}/Guild");
                if(ourGuild.GetQuests().Count <= 0) { GenarateQuests(12); }
            }
            private void LoadAventerurersBtns() {
            // Load Adverturer Button to the screen from the file system
            ClearAdventurerBtns();
            int index = 0;
            // Get each direcectory in the save directory
            foreach (string path in Directory.GetDirectories(savesPath)) {
                // Spilt the path to the adventurer to get the name and location their files to get their rank
                string[] splitPath = path.Split('\\');
                string name = splitPath[splitPath.Length - 1];
                StreamReader file = new StreamReader(path + "/data.txt");
                string rank = file.ReadLine();
                file.Close();

                // Create the buttons to display from info gain above
                AdventerurerBtn(ReplaceUnderscores(name), ReplaceUnderscores(rank), index);
                index++;
            }
        }
            private Adventurer LoadAdventurer(string adventurerData) {
                string[] data = adventurerData.Split();
                string name = ReplaceUnderscores(data[0]);
                string rank = GetRank(data[1]);
                int coins = GetCoins(data[2]);
                return new Adventurer(name, rank, coins);
            }
            private List<Adventurer> LoadGuildMembers(List<string> membersdata) {
                List<Adventurer> members = new List<Adventurer>();
                foreach (string member in membersdata) {
                    members.Add(LoadAdventurer(member));
                }
                return members;
            }
            private Guild LoadGuild(string guildpath) {
                if (!Directory.Exists(guildpath)) {
                    Directory.CreateDirectory(guildpath);
                    return new Guild();
                }

                List<string> membersdata = OpenFile($"{guildpath}/members.txt");
                List<string> questdata = OpenFile($"{guildpath}/quests.txt");
                int coins = GetGuildCoins($"{guildpath}/details.txt");
                List<Adventurer> members = LoadGuildMembers(membersdata);
                List<Quest> quests = LoadGuildQuest(questdata);

                return new Guild(members, quests, coins);
            }
            private int GetGuildCoins(string filepath) {
                StreamReader guildDetailFile = new StreamReader(filepath);
                string getCoinData = ReplaceUnderscores(guildDetailFile.ReadLine());
                int coins = int.Parse(getCoinData.Split()[1]);
                guildDetailFile.Close();
                return coins;
            }
            private Quest LoadQuest(string questData) {
                string[] data = questData.Split();
                string name = ReplaceUnderscores(data[0]);
                string rank = GetRank(data[1]);
                int reward = GetCoins(data[2]);
                int cost = GetCoins(data[3]);
                float difficultly = GetDifficultly(data[4]);
                return new Quest(name, rank, reward, cost, difficultly);
            }
            private List<Quest> LoadGuildQuest(List<string> questsdata) {
                List<Quest> quests = new List<Quest>();
                foreach(string quest in questsdata) {
                    quests.Add(LoadQuest(quest));
                }
                return quests;
            }

            // Save Files
            private void Save() {
                string playerPath = $"{savesPath}/{ReplaceSpaces(ourAdventurer.GetName())}";
                SaveAdventurerData(playerPath);
                SaveGuildData($"{playerPath}/Guild");
            }
            private void SaveAdventurerData(string playerPath) {
                // Info Data
                StreamWriter datafile = new StreamWriter($"{playerPath}/data.txt", false);
                datafile.WriteLine($"RANK_{ourAdventurer.GetRank()}");
                datafile.WriteLine($"COINS_{ourAdventurer.GetCoins()}");
                datafile.Close();
                // Quests data
                StreamWriter questfile = new StreamWriter($"{playerPath}/quests.txt", false);
                List<Quest> quests = ourAdventurer.GetQuestList();
                foreach (Quest quest in quests) {
                    string name = ReplaceSpaces(quest.GetQuestName());
                    string rank = quest.GetQuestRank();
                    string reward = quest.GetQuestReward().ToString();
                    string cost = quest.GetCostOfSupplies().ToString();
                    string diff = quest.GetQuestDifficultly().ToString();
                    string completed = quest.IsCompleted().ToString().ToUpper();
                    questfile.WriteLine($"{name} RANK_{rank} " +
                        $"REWARD_{reward} COST_{cost} DIFFICULTLY_{diff} " +
                        $"COMPLETED_{completed}");
                }
                questfile.Close();
            }
            private void SaveGuildData(string guildPath) {
                // Details data
                StreamWriter detailfile = new StreamWriter($"{guildPath}/details.txt", false);
                // Defualt valuse for now
                // TODO: Update guild details for telling different times and calculate profit
                detailfile.WriteLine($"TOTALCOINS_{ourGuild.GetCoins()}");
                detailfile.WriteLine("CURRENTPROFIT_530");
                detailfile.WriteLine("CURRENTDAY_12");
                detailfile.Close();
                // Members data
                StreamWriter memberfile = new StreamWriter($"{guildPath}/members.txt", false);
                List<Adventurer> guildMembers = ourGuild.GetAdventurers();
                foreach (Adventurer member in guildMembers) {
                    string name = ReplaceSpaces(member.GetName());
                    string rank = member.GetRank();
                    int coins = member.GetCoins();
                    memberfile.WriteLine($"{name} RANK_{rank} COINS_{coins}");
                }
                memberfile.Close();
                // Quests data
                StreamWriter questfile = new StreamWriter($"{guildPath}/quests.txt", false);
                List<Quest> quests = ourGuild.GetQuests();
                foreach (Quest quest in quests) {
                    string name = ReplaceSpaces(quest.GetQuestName());
                    string rank = quest.GetQuestRank();
                    string reward = quest.GetQuestReward().ToString();
                    string cost = quest.GetCostOfSupplies().ToString();
                    string diff = quest.GetQuestDifficultly().ToString();
                    questfile.WriteLine($"{name} RANK_{rank} " +
                        $"REWARD_{reward} COST_{cost} DIFFICULTLY_{diff} ");
                }
                questfile.Close();
            }
        #endregion
    }

}





