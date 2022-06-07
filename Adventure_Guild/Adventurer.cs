using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Guild {
    class Adventurer {
        
        private List<Quest> questList;
        private string name;
        private string rank;
        private int coins;

        private float rankProgress = 0.0f;

        #region Constructors
            // Construtor for new adventurers
            public Adventurer(string adventurerName) {
                name = adventurerName;
                rank = "E";
                coins = 50;
                questList = new List<Quest>();
            }

            // Construtor for saved adventurers
            public Adventurer(string adventurerName, string adventurerRank, int adventurerCoins) {
                name = adventurerName;
                rank = adventurerRank;
                coins = adventurerCoins;
                questList = new List<Quest>();
            }
        #endregion

        #region GETTERS / SETTERS
            // Getters
            public string GetName() { return name; }
            public string GetRank() { return rank; }
            public int GetCoins() { return coins; }
            public List<Quest> GetQuestList() { return questList; }

            // Setters
            public void SetName(string adventurerName) { name = adventurerName; }
            public void SetRank(string adventurerRank) { rank = adventurerRank; }
            public void SetCoins(int adventurerCoins) { coins = adventurerCoins; }
            public void SetQuestList(List<Quest> adventurerQuests) { questList = adventurerQuests; }
        #endregion


        // Extra Methods
        public int GetAmountOfCompletedQuest() {
            if (questList.Count <= 0) {
                return 0;
            }

            int completedQuest = 0;
            foreach(Quest quest in questList) {
                if (quest.IsCompleted()) {
                    completedQuest += 1;
                }
            }

            return completedQuest;
        } // Find out how many quest the adventurer has completed
        public void DoQuest(Quest guildquest) {
            Quest quest = CopyQuest(guildquest);
            string questRank = quest.GetQuestRank();
            int rankLvlComparison = CompareQuestLvl(questRank);
            float questDifficultly = quest.GetQuestDifficultly();
            float skillLevel = DetermineSkillLevel();
            float increaseProgress;

            // Doing same rank quest
            if (rank == questRank) {
                // get the rank progress completion reward
                increaseProgress = 0.75f / (questDifficultly * 75); // Random Values that I am trying
                questDifficultly -= skillLevel;
            } else if (rankLvlComparison == 1) {
                // higher rank
                // Can do one level higher ranked quest but the difficult will increase
                increaseProgress = 0.75f / ((questDifficultly - 0.02f) * 75);
                questDifficultly += 0.05f - skillLevel;
            } else if (rankLvlComparison < 0 ){
                // lower rank
                // Can do lower quest but the reward for ranking up will be lowered
                increaseProgress = 0.75f / ((questDifficultly + (0.02f * MathF.Abs(rankLvlComparison))) * 75);
                questDifficultly -= (0.05f * MathF.Abs(rankLvlComparison)) - skillLevel;
            } else {
                // Something messed up
                return;
            }

            int costOfSupplies = quest.GetCostOfSupplies();
            if(coins - costOfSupplies < 0) {
                float coverPercentage = coins / costOfSupplies;
                coins = 0;
                questDifficultly += (0.02f * coverPercentage);
            }

            coins -= costOfSupplies;

            if (CompletedQuest(questDifficultly)) {
                rankProgress += increaseProgress;
                quest.SetQuestCompletion(true);
                coins += quest.GetQuestReward();
                if (rankProgress >= 1 && rank != "SS") {
                    RankUp();
                }
            }

            StoreQuest(quest);
        } // Allow adventurer to do the quest
        public bool GetLastQuestCompletion() { 
            return questList[questList.Count - 1].IsCompleted(); 
        } // See if completed last quest did
        private Quest CopyQuest(Quest quest) {
            string name = quest.GetQuestName();
            string rank = quest.GetQuestRank();
            int reward = quest.GetQuestReward();
            int cost = quest.GetCostOfSupplies();
            float diff = quest.GetQuestDifficultly();
            return new Quest(name, rank, reward, cost, diff);
        } // Copys guild quest to keep record of quest but not change guild's quest
        private void StoreQuest(Quest quest) {
            questList.Add(quest);
        } // Add a new quest to our list
        private int CompareQuestLvl(string questRank) {
            int ourRankLvl = Guild.GetRankValue(rank);
            int questRankLvl = Guild.GetRankValue(questRank);
            return questRankLvl - ourRankLvl;
        } // Compare adventurer rank with quest rank
        private bool CompletedQuest(float difficultly) {
            float randNum = new Random().Next(0, 100) / 100f;
            if (randNum > difficultly) {
                return true;
            }

            return false;
        } // See if complete quest
        private float DetermineSkillLevel() {
            switch(rank) {
                case "E":
                    return GetSkillLevel(1, 4);
                case "F":
                    return GetSkillLevel(4, 12);
                case "D":
                    return GetSkillLevel(11, 17);
                case "C":
                    return GetSkillLevel(15, 21);
                case "B":
                    return GetSkillLevel(21, 27);
                case "A":
                    return GetSkillLevel(27, 38);
                case "S":
                    return GetSkillLevel(36, 41);
                case "SS":
                    return GetSkillLevel(41, 50);
                default:
                    throw new Exception("SKill Level couldn't be determined." + $" Your Rank input: {rank}.");
            }
        } // Balence out the difficult level of the quest with skill level of adventurer
        private float GetSkillLevel(int minSkill, int maxSkill) {
            float skillLevel = new Random().Next(minSkill, maxSkill) / 100f;
            return skillLevel + (skillLevel * rankProgress);
        } // Calculate skill level
        private void RankUp() {
            rankProgress = 0;
            switch (rank) {
                case "E":
                    rank = "F";
                    break;
                case "F":
                    rank = "D";
                    break;
                case "D":
                    rank = "C";
                    break;
                case "C":
                    rank = "B";
                    break;
                case "B":
                    rank = "A";
                    break;
                case "A":
                    rank = "S";
                    break;
                case "S":
                    rank = "SS";
                    break;
            }
        } // Change Rank
    }
}
