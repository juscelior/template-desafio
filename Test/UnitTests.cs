namespace Test;

public class UnitTests
{
    private List<int> numerosBase = new List<int> {1,2,3,4,5,6,7,8,9,10};


    [Fact]
    public void Test_desafio_01_filtro_loop_numeros_pares()
    {
        //Utilize um loop para filtrar números pares da lista numerosBase. 
        List<int> numerosPares = null;

        //TODO

        Assert.NotNull(numerosPares);
        Assert.Collection(numerosPares, 
                n => Assert.True(n % 2 == 0)
            );
    }

    [Fact]
    public void Test_desafio_02_filtro_lambda_numeros_impares()
    {
        //Utilize lambda para filtrar números ímpares da lista numerosBase.
        List<int> numerosImpares = null;

        //TODO

        Assert.NotNull(numerosImpares);
        Assert.Collection(numerosImpares, 
                n => Assert.True(n % 2 == 0)
            );
    }


    [Fact]
    public void Test_desafio_03_contador_letra()
    {
        //Calcule o número de ocorrências da letra e dentro frase, e salve esse valor na variável countE.
        string frase = "Não deixe para amanhã aquilo que você pode fazer hoje";
        int countE = 0;

        //TODO
        
        Assert.NotNull(countE);
        Assert.Equal(countE, 7);
    }

}