namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test_desafio_01()
    {
        List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

        Assert.NotNull(numeros);
    }
}