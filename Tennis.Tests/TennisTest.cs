namespace Tennis.Tests;

public class TennisTest
{
    [Fact]
    public void เริ่มเกม_Score_ของ_PlayerA_เป็น_Love_PlayerB_เป็น_Love()
    {
        // Arrange
        var expectedScorePlayerA = "Love";
        var expectedScorePlayerB = "Love";
        Tennis tennis = new Tennis();

        // Act
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }

    [Fact]
    public void บอลที่1_PlayerA_ชนะ_Score_ของ_PlayerA_เป็น_Fifteen_PlayerB_เป็น_Love()
    {
        // Arrange
        var expectedScorePlayerA = "Fifteen";
        var expectedScorePlayerB = "Love";
        Tennis tennis = new Tennis();

        // Act
        tennis.WinForPlayerA();
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }

    [Fact]
    public void บอลที่2_PlayerB_ชนะ_Score_ของ_PlayerA_เป็น_Fifteen_PlayerB_เป็น_Fifteen()
    {
        // Arrange
        var expectedScorePlayerA = "Fifteen";
        var expectedScorePlayerB = "Fifteen";
        Tennis tennis = new Tennis();

        // Act
        tennis.WinForPlayerA(); // บอลที่1
        tennis.WinForPlayerB(); // บอลที่2
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }

    [Fact]
    public void บอลที่3_PlayerB_ชนะ_Score_ของ_PlayerA_เป็น_Fifteen_PlayerB_เป็น_Thirty()
    {
        // Arrange
        var expectedScorePlayerA = "Fifteen";
        var expectedScorePlayerB = "Thirty";
        Tennis tennis = new Tennis();

        // Act
        tennis.WinForPlayerA(); // บอลที่1
        tennis.WinForPlayerB(); // บอลที่2
        tennis.WinForPlayerB(); // บอลที่3
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }

    [Fact]
    public void บอลที่4_PlayerA_ชนะ_Score_ของ_PlayerA_เป็น_Thirty_PlayerB_เป็น_Thirty()
    {
        // Arrange
        var expectedScorePlayerA = "Thirty";
        var expectedScorePlayerB = "Thirty";
        Tennis tennis = new Tennis();

        // Act
        tennis.WinForPlayerA(); // บอลที่1
        tennis.WinForPlayerB(); // บอลที่2
        tennis.WinForPlayerB(); // บอลที่3
        tennis.WinForPlayerA(); // บอลที่4
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }

    [Fact]
    public void บอลที่5_PlayerA_ชนะ_Score_ของ_PlayerA_เป็น_Forty_PlayerB_เป็น_Thirty()
    {
        // Arrange
        var expectedScorePlayerA = "Forty";
        var expectedScorePlayerB = "Thirty";
        Tennis tennis = new Tennis();

        // Act
        tennis.WinForPlayerA(); // บอลที่1
        tennis.WinForPlayerB(); // บอลที่2
        tennis.WinForPlayerB(); // บอลที่3
        tennis.WinForPlayerA(); // บอลที่4
        tennis.WinForPlayerA(); // บอลที่5
        string scorePlayerA = tennis.GetScorePlayerA();
        string scorePlayerB = tennis.GetScorePlayerB();

        // Assert
        Assert.Equal(expectedScorePlayerA, scorePlayerA);
        Assert.Equal(expectedScorePlayerB, scorePlayerB);
    }
}