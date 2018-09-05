using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal
            // nivelDeAzul = -3;

            short passageirosVoo = 230; //System.Int16
            passageirosVoo = -7;

            int populacao = 1500; // System.Int32
            populacao = -2300;

            long populacaoBrasil = 207_660_929; // System.Int64 +/- 207 milões

            sbyte nivelBrilho = -127; // System.Sbyte permite byte negativo

            ushort passageirosNavio = 230; // System.UInt16 não pode negativo

            uint estoque = 1500; //System.UInt32 não pode negativo

            ulong populacaoDoMundo = 7_000_000_000; //System.UInt64 não pode negativo


            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");


            //erros

            //nivelDeAzul = 0xFFFF; // = 65535 em decimal
            //passageirosVoo = 230000; // System.Int16 
            //populacao = 15000000000; // System.Int32 
            //ushort passageirosNavio = -15; // System.UInt16 
            //uint estoque = -2300; // System.UInt32 
            //long populacaoDoBrasil = 207_660_929.345; //casas decimais
        }
    }
}
