using System;
using System.IO;
namespace Higor{
  class MainClass {
    public static void Main (string[] args) {
      Random randNum = new Random();
      Cartao meuCard = new Cartao(150, randNum.Next(10));
      
      meuCard.comprar(randNum.Next(150));
      meuCard.comprar(randNum.Next(150));
      meuCard.comprar(randNum.Next(150));

      Console.WriteLine("Valor Fatura: {0}",meuCard.fecharFatura());

      meuCard.listadeCompras(); 


/*      
      //Lendo arquivos
      StreamReader arquivo;
      arquivo = File.OpenText("fatura.txt");
      string original = arquivo.ReadLine();
      Console.WriteLine(original);
      arquivo.Close(); // Fechar o arquivo antes de usar-lo novamente
     
      //Escrevendo em arquivos

      StreamWriter saida;
      saida = File.AppendText("fatura.txt");
        saida.WriteLine("Azul");
      saida.Close();
*/
    }
  }
}