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
        if (score == 45) {
            return "Forty"; //  บอลที่3
        }
        if (score == 30) {
            return "Thirty"; //  บอลที่2
        }
        if (score == 15) {
            return "Fifteen"; //  บอลที่1
        }
        return "Love"; // บอลที่0
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
