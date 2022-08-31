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
}