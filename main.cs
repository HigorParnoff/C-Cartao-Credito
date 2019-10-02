using System;

class MainClass {
  public static void Main (string[] args) {
    Cartao meuCard = new Cartao(30);
    meuCard.comprar(1,0,54.99);
     meuCard.comprar(1,1,99);
    meuCard.comprar(1,2,9.0);
    meuCard.ver_fatura(); 

    Cartao Card2 = new Cartao(10);
    Card2.comprar(11, 2, 98.76);
    Card2.ver_fatura(); 


  }
}