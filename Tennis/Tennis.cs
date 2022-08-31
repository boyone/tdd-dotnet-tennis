namespace Tennis;
public class Tennis
{
    private int scoreA;

    public string GetScorePlayerA()
    {
        if (scoreA == 15) {
            return "Fifteen";
        }
        return "Love";
    }

    public string GetScorePlayerB()
    {
        return "Love";
    }

    public void WinForPlayerA()
    {
        scoreA += 15;
    }
}
