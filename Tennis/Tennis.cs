namespace Tennis;
public class Tennis
{
    private int scoreA;
    private int scoreB;
    private string[] scores = { "Love", "Fifteen", "Thirty", "Forty" };

    public string GetScorePlayerA()
    {
        return scores[scoreA];
    }

    public string GetScorePlayerB()
    {
        return scores[scoreB];
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
