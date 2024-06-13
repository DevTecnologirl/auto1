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

            //verificação
            Assert.That(soma, Is.EqualTo(resultSoma));
            Console.WriteLine("O resultado da soma é " + resultSoma);
        }

        //execução e organização dos testes no explorer
        [Test]
        public void Test1()
        {
            a = 5; b = 7;
            multi = a * b;
            resultMulti = 35;

            //verificação
            Assert.That(multi, Is.EqualTo(resultMulti));
            Console.WriteLine("O resultado da multiplicação é " + resultMulti);
        }

        //executa o que estiver dentro do método após execução dos testes
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
                Console.WriteLine("O valor da Multiplicação deve ser " + multi);
                Console.WriteLine("O valor digitado foi " + resultMulti); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Muito bem! Você acertou!");
            }
        }
    }
}