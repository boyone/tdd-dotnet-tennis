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
        if (score == 30) {
            return "Thirty";
        }
        if (score == 15) {
            return "Fifteen";
        }
        return "Love";
    }

    public void WinForPlayerA()
    {
        scoreA += 15;
    }

    public void WinForPlayerB()
    {
        scoreB += 15;
    }
}
