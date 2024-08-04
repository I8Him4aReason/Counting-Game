using System;                                     // בס"ד
using System.Collections.Generic;
using System.Linq;

namespace Counting_Game_Library
{
    public class CountingGame
    {
        // FIELDS AND AUTO-IMPLEMENTED PROPERTIES

        protected Random rnd = new Random();

        private int targetNumber = 100;
        private int currentTotal = 0;

        private int minRange = 1;
        private int maxRange = 10;

        private int difficulty = 100;
        private int mode = 1;

        private int gameNumber = 1;
        private int computerWins = 0;
        private int userWins = 0;

        public bool AdditionMode { get; private set; } = true;
        public bool ExceedingTargetIsWin { get; private set; } = true;
        public bool ReachingTargetIsWin { get; private set; } = true;

        public bool ComputerStarts { get; set; } = true;




        // GET AND SET PROPERTIES

            // Target Number
        public int TargetNumber => targetNumber;

        public void SetTargetNumber(int targetNumber)
        {
            this.targetNumber = targetNumber;
            ResetTotal();
        }


            // Current Total
        public int CurrentTotal => currentTotal;

        public void ResetTotal()
        {
            currentTotal = AdditionMode ? 0 : targetNumber;
        }


            // Range
        public int MinRange => minRange;

        public int MaxRange => maxRange;

        public void SetRange(int min, int max)
        {
            maxRange = max;
            minRange = min;
        }


            // Difficulty
        public string GetDifficulty()
        {
            double d = (double)difficulty / targetNumber;

            if (d < 0.2) return "very easy";
            if (d < 0.4) return "easy";
            if (d < 0.6) return "medium";
            if (d < 0.8) return "hard";
            if (d < 1) return "expert";
            return "insane";
        }

        public void SetDifficulty(int numerator, int denominator)
        {
            difficulty = numerator * targetNumber / denominator;
        }


            // Mode
        public string ModeLabel => "Mode: " + mode; 

        public int Mode
        {
            get { return mode; }
            set
            {
                if (Enumerable.Range(1, 6).Contains(value))
                    mode = value;

                switch (mode)
                {
                    case 1:
                        SetGameTypeToAddition();
                        break;
                    case 2:
                        SetGameTypeToAddition(false, false);
                        break;
                    case 3:
                        SetGameTypeToAddition(false, true);
                        break;
                    case 4:
                        SetGameTypeToAddition(true, false);
                        break;
                    case 5:
                        SetGameTypeToSubtraction();
                        break;
                    case 6:
                        SetGameTypeToSubtraction(false);
                        break;
                }
            }
        }

        private void SetGameTypeToAddition(bool ExceedingTargetIsWin = true, bool ReachingTargetIsWin = true)
        {
            AdditionMode = true;
            this.ExceedingTargetIsWin = ExceedingTargetIsWin;
            this.ReachingTargetIsWin = ReachingTargetIsWin;
        }
        
        private void SetGameTypeToSubtraction(bool ReachingZeroIsWin = true)
        {
            AdditionMode = false;
            this.ExceedingTargetIsWin = ReachingZeroIsWin;
            this.ReachingTargetIsWin = ReachingZeroIsWin;
        }

        public string GetInstructions(bool ExtraLineBreaks = true, bool AllSameNumberOfLines = false)
        {
            return GetInstructions(Mode, ExtraLineBreaks, AllSameNumberOfLines);
        } 

        public static string GetInstructions(int mode, bool ExtraLineBreaks = true, bool AllSameNumberOfLines = false)
        {
            string enter = LineBreak(ExtraLineBreaks);
            string enter2 = LineBreak(AllSameNumberOfLines);
            string enter3 = LineBreak(AllSameNumberOfLines && ExtraLineBreaks);

            switch (mode)
            {
                case 1:
                    return
                        "In this game, Players take turns ADDING numbers from a specified range. " +
                        "\r\n" + "Each number added contributes to a shared total. " +
                        "\r\n" + enter + "The player who brings the total to a certain target number, or exceeds it, is the winner! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter2 + enter3 + enter3;
                case 2:
                    return
                        "In this game, Players take turns ADDING numbers from a specified range. " +
                        "\r\n" + "Each number added contributes to a shared total. " +
                        "\r\n" + enter + "The player who brings the total to a certain target number, or exceeds it, loses! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter2 + enter3 + enter3;
                case 3:
                    return
                        "In this game, Players take turns ADDING numbers from a specified range. " +
                        "\r\n" + "Each number added contributes to a shared total. " +
                        "\r\n" + enter + "The player who brings the total to a certain target number is the winner! " +
                        "\r\n" + "But be careful! If you EXCEED the target number you lose! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter3 + enter3;
                case 4:
                    return
                        "In this game, Players take turns ADDING numbers from a specified range. " +
                        "\r\n" + "Each number added contributes to a shared total. " +
                        "\r\n" + enter + "The player who brings the total to EXCEED a certain target number is the winner! " +
                        "\r\n" + "But be careful! If you bring the total to the target number itself you lose! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter3 + enter3;
                case 5:
                    return
                        "In this game, Players take" +
                        enter + "turns SUBTRACTING numbers from a specified total. " +
                        "\r\n" + "You may subtract a number only if it falls within a predefined range. " +
                        "\r\n" + enter + "The player to bring the total to ZERO" +
                        enter + " (or less) is declared the winner! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter2;
                case 6:
                    return
                        "In this game, Players take" +
                        enter + "turns SUBTRACTING numbers from a specified total. " +
                        "\r\n" + "You may subtract a number only if it falls within a predefined range. " +
                        "\r\n" + enter + "The player to bring the total to ZERO" +
                        enter + " (or less) is declared the loser! " +
                        "\r\n" + "You will be playing against the computer. " +
                        "\r\n" + "Good luck!" + enter2;

                default:
                    return null;
            }
        }

        private static string LineBreak(bool LineBreaks)
        {
            return LineBreaks ? "\r\n" : "";
        }


            // Game Number And Score
        public string GameNumber => "Game: " + gameNumber;

        public string Score => userWins.ToString() + " - " + computerWins.ToString();




        // METHODS

            // Turns
        public void UpdateTotalWithUserNumber(int userNum)
        {
            AddNumberToTotal(userNum);
        }

        public void UpdateTotalWithUserNumberIfInRange(int userNum)
        {
            if (IsInRange(userNum))
                UpdateTotalWithUserNumber(userNum);
        }

        public int GetComputerNumberAndUpdateTotal()
        {
            int computerNumber = GetComputerNumber();
            AddNumberToTotal(computerNumber);
            return computerNumber;
        }

        private void AddNumberToTotal(int number)
        {
            if (AdditionMode)
                currentTotal += number;
            else
                currentTotal = Math.Max(currentTotal - number, 0);
        }


            // End Game
        public bool IsGameOver()
        {
            if (AdditionMode)
                return currentTotal >= targetNumber;
            return currentTotal == 0;
        }

        public bool IsWin()
        {
            if (!IsGameOver()) return false;

            if (AdditionMode && currentTotal == targetNumber)
                return ReachingTargetIsWin;
            return ExceedingTargetIsWin;

        }

        public bool IsInRange(int userNum)
        {
            return userNum >= minRange && userNum <= maxRange;
        }


            // Game Number And Score
        public void IncrementGameNumber()
        {
            gameNumber++;
        }

        public void AddToComputerWins()
        {
            computerWins++;
        }

        public void AddToUserWins()
        {
            userWins++;
        }

        public bool IsScoreZeroZero()
        {
            return userWins == 0 && computerWins == 0;
        }

        public void ResetScoreAndGameNumber()
        {
            userWins = 0;
            computerWins = 0;
            gameNumber = 1;
        }


            // Game Logic
        private int RandomNumInRange()
        {
            return rnd.Next(minRange, maxRange + 1);
        }

        private int GetComputerNumber()
        {
            // if its outside of the difficulty, return a random number
            if (AdditionMode && targetNumber - currentTotal > difficulty
                   ||
               !AdditionMode && currentTotal > difficulty)
            {
                return RandomNumInRange();
            }

            return GetPerfectComputerNumber();
        }

        public int GetPerfectComputerNumber()
        {
            int q = GetQScore(CurrentTotal);

            // if the total is a losing number, return a random number
            if (q > maxRange)
                return RandomNumInRange();

            // return a random number that will bring the total to a losing number
            return rnd.Next(Math.Max(q, minRange), Math.Min(q + minRange - 1, maxRange) + 1);
        }
      
        private int GetQScore(int total)
        {
            // The Q-Score is basically the distance from the target number, but mod of the sum of the range

            total = GetTotalIfItWasAllWin(total);

            int q = AdditionMode ?
                (targetNumber - total) % (minRange + maxRange) : total % (minRange + maxRange);

            if (q < 0)
                q = -q;

            if (q == 0)
                q = minRange + maxRange;

            return q;
        }

        private int GetTotalIfItWasAllWin(int total)
        {
            // all win - meaning if both of these are true: ExceedingTargetIsWin , ReachingTargetIsWin
            
            if (ExceedingTargetIsWin && ReachingTargetIsWin)
                return total;

            if (ExceedingTargetIsWin && !ReachingTargetIsWin)
                return total - 1;

            if (!ExceedingTargetIsWin && !ReachingTargetIsWin)
                return total - maxRange;

            if (!ExceedingTargetIsWin && ReachingTargetIsWin)
                return total - maxRange - 1;

            return -1;
        }

        private bool IsLoss(int total)
        {
            return GetQScore(total) > maxRange;
        }

        public string CheatSheat()
        {
            string sheet = "";
            sheet += AdditionMode ?
                $"Target Number: {TargetNumber}" :
                $"Starting Number: {TargetNumber}";
            sheet += "\r\n";
            sheet += $"Range: {MinRange} - {MaxRange}";
            sheet += "\r\n";
            sheet += ModeLabel;
            sheet += "\r\n\r\n";

            var lossNumbers = Enumerable.Range(0, TargetNumber).Where(i => IsLoss(i)).ToList();

            if (lossNumbers.Count == 0)
                return sheet + "There are no Losing Numbers";

            sheet += "Here are the losing numbers: ";
            sheet += "\r\n";

            for (int j = 0; j < lossNumbers.Count; j++)
            {
                sheet += lossNumbers[j];

                // Add a comma if it's not the last item
                if (j < lossNumbers.Count - 1)
                    sheet += ", ";

                // Add a newline every 6 items
                if ((j + 1) % 6 == 0 && j < lossNumbers.Count - 1)
                    sheet += "\r\n";
            }

            return sheet; ;
        }

    }
}