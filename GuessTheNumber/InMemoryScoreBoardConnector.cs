namespace GuessTheNumber
{
    public class InMemoryScoreboardConnector : IScoreboardConnector
    {
        private List<ScoreEntry> scores = new List<ScoreEntry>();

        public void AddScore(ScoreEntry score)
        {
            scores.Add(score);
            scores = scores.OrderBy(s => s.Attempts).ToList();
        }

        public List<ScoreEntry> GetTopScores(int count)
        {
            return scores.Take(count).ToList();
        }
    }
}

