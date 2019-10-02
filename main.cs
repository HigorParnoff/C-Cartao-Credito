using System;

class MainClass {
  public static void Main (string[] args) {
    double compra;
    Cartao meuCard = new Cartao(200);
    Console.WriteLine("VALOR:");
    compra = double.Parse(Console.ReadLine());
    if(meuCard.comprar(compra)==true){
      Console.WriteLine("COMPRA EFETUADA");
    }
    else{
      Console.WriteLine("COMPRA RECUSADA");
    }
  }
}