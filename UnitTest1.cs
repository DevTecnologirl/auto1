using System;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        //executado antes de qualquer teste
        public int a, b, soma, multi, resultSoma, resultMulti;

        [SetUp]
        public void Soma()
        {
            a = 5; b = 7;
            soma = a + b;
            resultSoma = 12;

            //verifica��o
            Assert.That(soma, Is.EqualTo(resultSoma));
            Console.WriteLine("O resultado da soma � " + resultSoma);
        }

        //execu��o e organiza��o dos testes no explorer
        [Test]
        public void Test1()
        {
            a = 5; b = 7;
            multi = a * b;
            resultMulti = 35;

            //verifica��o
            Assert.That(multi, Is.EqualTo(resultMulti));
            Console.WriteLine("O resultado da multiplica��o � " + resultMulti);
        }

        //executa o que estiver dentro do m�todo ap�s execu��o dos testes
        [TearDown]
        public void Resultado()
        {
            if (soma != resultSoma)
            {
                Console.WriteLine("O valor da soma deve ser " + soma);
                Console.WriteLine("O valor digitado foi  " + resultSoma); Assert.Fail();
            }
            if (multi != resultMulti)
            {
                Console.WriteLine("O valor da Multiplica��o deve ser " + multi);
                Console.WriteLine("O valor digitado foi " + resultMulti); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Muito bem! Voc� acertou!");
            }
        }
    }
}