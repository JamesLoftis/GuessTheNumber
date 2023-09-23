namespace GuessTheNumber
{
    public interface IScoreboardConnector
    {
        void AddScore(ScoreEntry score);
        List<ScoreEntry> GetTopScores(int count);
    }
}
