using System;

namespace FootballScoreCombinations.Models
{
    public static class ScoreCalculator
    {
        public static int CalculateCombinations(int score)
        {
            if (score < 0) return 0;

            int combinations = 0;

            // Loop para verificar cada possível combinação de touchdowns e field goals
            for (int touchdowns = 0; touchdowns <= score / 6; touchdowns++)
            {
                for (int extraPoints = 0; extraPoints <= touchdowns * 2; extraPoints++)
                {
                    for (int fieldGoals = 0; fieldGoals <= score / 3; fieldGoals++)
                    {
                        if (touchdowns * 6 + extraPoints + fieldGoals * 3 == score)
                        {
                            combinations++;
                        }
                    }
                }
            }

            return combinations;
        }
    }
}
