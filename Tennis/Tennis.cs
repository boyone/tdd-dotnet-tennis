namespace Tennis;
public class Tennis
{
    private int scoreA;
    private int scoreB;

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
        string[] scores = {"Love", "Fifteen", "Thirty", "Forty"};
        return scores[score];
    }

    public void WinForPlayerA()
    {
        scoreA ++;
    }

    public void WinForPlayerB()
    {
        scoreB ++;
    }
}
