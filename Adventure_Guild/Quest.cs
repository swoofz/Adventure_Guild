using System;
using System.Collections.Generic;
using System.Text;
    
namespace Adventure_Guild {
    class Quest {

        private string name;
        private string rank;
        private int reward;
        private int costOfsupplies;
        private float difficultly;
        private bool completed;

        #region Constructors
            public Quest(string questName, string questRank) {
                name = questName;
                rank = questRank;
                completed = false;
                try {
                    difficultly = FindDifficultlyValue();
                } catch(Exception e) {
                    throw new Exception("Failed to initialize Quest object...");
                }
                reward = MakeRandomReward();
                costOfsupplies = DetermineCostOfSupplies();
        } // Create new Quest
            public Quest(string questName, string questRank, int questReward, int questCost, float questDifficultly) {
                name = questName;
                rank = questRank;
                reward = questReward;
                costOfsupplies = questCost;
                difficultly = questDifficultly;
                completed = false;
        } // Load Quest data
        #endregion

        #region GETTERS / SETTERS
        // Getters
        public string GetQuestName() { return name; }
            public string GetQuestRank() { return rank; }
            public int GetQuestReward() { return reward; }
            public int GetCostOfSupplies() { return costOfsupplies; }
            public float GetQuestDifficultly() { return difficultly; }
            public bool IsCompleted() { return completed; }

            // Setters
            public void SetRank(string questRank) { rank = questRank; }
            public void SetReward(int questReward) { reward = questReward; }
            public void SetCostOfSupplies(int supplyCost) { costOfsupplies = supplyCost; }
            public void SetDifficultly(float diff) { difficultly = diff; }
            public void SetQuestCompletion(bool isComplete) { completed = isComplete; }
        #endregion

        // Extra Methods
        private float FindDifficultlyValue() {
            switch (rank) {
                case "E":
                    return new Random().Next(1, 7) / 100f;
                case "F":
                    return new Random().Next(7, 23) / 100f;
                case "D":
                    return new Random().Next(21, 33) / 100f;
                case "C":
                    return new Random().Next(30, 43) / 100f;
                case "B":
                    return new Random().Next(43, 55) / 100f;
                case "A":
                    return new Random().Next(55, 76) / 100f;
                case "S":
                    return new Random().Next(71, 82) / 100f;
                case "SS":
                    return new Random().Next(81, 100) / 100f;
                default:
                    throw new Exception("Difficultly couldn't be set." + $" Your Rank input: {rank}.");
            }
        } // Set the difficultly of the quest
        private int MakeRandomReward() {
            switch (rank) {
                case "E":
                    return new Random().Next(100, 500);
                case "F":
                    return new Random().Next(350, 700);
                case "D":
                    return new Random().Next(500, 1050);
                case "C":
                    return new Random().Next(1500, 3000);
                case "B":
                    return new Random().Next(5000, 8700);
                case "A":
                    return new Random().Next(10000, 15000);
                case "S":
                    return new Random().Next(35000, 55000);
                case "SS":
                    return new Random().Next(45000, 100000);
                default:
                    throw new Exception("Couldn't get a Reward." + $" Your Rank input: {rank}.");
            }
        } // Define quest reward
        private int DetermineCostOfSupplies() {
            float supplyCost = reward * 0.5f * difficultly;
            return (int)Math.Round(supplyCost, 0);
        } // Set the cost of the quest
    }
}
