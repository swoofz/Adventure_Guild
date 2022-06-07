using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Guild {
    class Guild {

        public enum Ranks { E, F, D, C, B, A, S, SS };

        private List<Adventurer> adventurers;
        private List<Quest> quests;
        private int coins;

        #region Constructors
            public Guild() {
                adventurers = new List<Adventurer>();
                quests = new List<Quest>();
                coins = 1000;
            }
            public Guild(List<Adventurer> loadAdventures, List<Quest> guildQuests, int money) {
            adventurers = loadAdventures;
            quests = guildQuests;
            coins = money;
        }
        #endregion

        #region GETTERS / SETTERS
            // Getters
            public int GetCoins() { return coins; }
            public List<Adventurer> GetAdventurers() { return adventurers; }
            public List<Quest> GetQuests() { return quests; }
            public static int GetRankValue(string rank) {
                switch (rank) {
                    case "E":
                        return (int)Ranks.E;
                    case "F":
                        return (int)Ranks.F;
                    case "D":
                        return (int)Ranks.D;
                    case "C":
                        return (int)Ranks.C;
                    case "B":
                        return (int)Ranks.B;
                    case "A":
                        return (int)Ranks.A;
                    case "S":
                        return (int)Ranks.S;
                    case "SS":
                        return (int)Ranks.SS;
                    default:
                        throw new Exception("Rank could be determined" + $" Your Rank input: {rank}.");
                }
            }

            // Setters
            public void SetCoins(int money) { coins = money; }
            public void SetAdventurers(List<Adventurer> adventurersList) { adventurers = adventurersList; }
            public void SetQuest(List<Quest> questList) { quests = questList; }
        #endregion

        //Extra Methods
        public void GainProfits(int profit) { coins += profit; } // Increase guild coins
        public void GetNewQuest(Quest newQuest) {
            if (quests.Count < 12) {  // only have 12 quest
                quests.Add(newQuest);
                GetPaymentForQuest(newQuest);
            } 
        } // Get a new quest for adventures to accept
        public Quest FindQuest(string questname) {
            foreach(Quest quest in quests) {
                if(quest.GetQuestName() == questname) {
                    return quest;
                }
            }

            return null;
        } // Find quest that matches the quest name given
        public void AddAdventurer(Adventurer newAdventurer) {
            if (adventurers.Count < 25) {
                adventurers.Add(newAdventurer);
            }
        } // Get new guild member
        public void RemoveQuest(Quest acceptedQuest) {
            if(quests.Contains(acceptedQuest)) {
                quests.Remove(acceptedQuest); 
            }
        } // Remove quest for our quest list
        public string PlayLottery() {
            double randomNum = new Random().NextDouble();

            // Random reward using a random number
            if (randomNum <= 0.15) {
                coins -= 750;
                return "You won a Great Axe";
            } else if (randomNum <= 0.35) {
                coins -= 75;
                return "You won one free night at the inn";
            } else if (randomNum <= 0.65) {
                coins -= 500;
                return "You won 500 coins";
            } else {
                coins -= 8;
                return "You won a free meal ticket";
            }
        } // Get a random reward
        public int GiveFreeInnTickets(Adventurer adventurer) {
            // Note: This when be avaiable weekly (timer)
            int questsCompleted = adventurer.GetAmountOfCompletedQuest();
            string advRank = adventurer.GetRank();
            int score = (int)Math.Ceiling(questsCompleted * (GetBonusPercentage(advRank) * 10));
            int innNightPrice = 75;
            
            if (score < 2) {
                coins -= (innNightPrice * 2);
                return 2;
            } else if (score < 6) {
                coins -= (innNightPrice * 6);
                return 4;
            } else {
                coins -= (innNightPrice * 7);
                return 7;
            }
        } // Get amount of free inn tickets
        public int GiveBonusCoins(Adventurer adventurer) {
            // TODO: Not sure if in this method or not but need to have a ways to determine profit diff from money have
            float bonusPercentage = GetBonusPercentage(adventurer.GetRank());
            int bonus = (int)Math.Round((coins / (adventurers.Count + 1)) * bonusPercentage);
            coins -= bonus;
            return bonus;
        } // Get adventurer's coin bonus
        private float GetBonusPercentage(string rank) {
            switch (rank) {
                case "E":
                    return 0.02f;
                case "F":
                    return 0.025f;
                case "D":
                    return 0.03f;
                case "C":
                    return 0.045f;
                case "B":
                    return 0.055f;
                case "A":
                    return 0.07f;
                case "S":
                    return 0.085f;
                case "SS":
                    return 0.1f;
                default:
                    throw new Exception("Bonus couldn't be determined." + $" Your Rank input: {rank}.");
            }
        } // Get adventurer's bonus percentage based on their rank
        private void GetPaymentForQuest(Quest quest) {
            int payment = (int)Math.Ceiling(quest.GetQuestReward() * (1-quest.GetQuestDifficultly()) * 0.05f);
            coins += payment;
        }
    }
}
