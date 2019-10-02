using System;

class Cartao {
  private double limite;
  private double [,] faturas;

  public Cartao (double l) {
   limite = l;

  }

  public bool comprar (double valor){
    if(limite-valor >= 0){
      limite = limite - valor;
      return true;
    }
    else{
      return false;
    }
    
  }
  
  public void ver_fatura(){
   //TODO
  }
}
