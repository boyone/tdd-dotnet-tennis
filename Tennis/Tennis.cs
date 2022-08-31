namespace Tennis;
public class Tennis
{
    private int scoreA;
    private int scoreB;
    private string[] scores = { "Love", "Fifteen", "Thirty", "Forty" };

    public string GetScorePlayerA()
    {
        return GetScore(scoreA);
    }

    public string GetScorePlayerB()
    {
        return GetScore(scoreB);
    }

    private string GetScore(int score)
    {
        return scores[score];
    }

    public void WinForPlayerA()
    {
        scoreA++;
    }

    public void WinForPlayerB()
    {
        scoreB++;
    }
}
