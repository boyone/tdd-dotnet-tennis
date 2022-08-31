namespace Tennis;
public class Tennis
{
    private int scoreA;
    private int scoreB;

    public string GetScorePlayerA()
    {
        if (scoreA == 15) {
            return "Fifteen";
        }
        return "Love";
    }

    public string GetScorePlayerB()
    {
        if (scoreB == 15) {
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
