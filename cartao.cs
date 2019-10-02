using System;

class Cartao {
  private int slots;
  private double [,] faturas;

  public Cartao (int qtd_slots) {
  slots = qtd_slots;
  faturas = new double [12, slots];
  }

  public void comprar (int mes, int pos, double valor){
    faturas[mes,pos] = valor;
  }
  
  public void ver_fatura(){
    for(int i=0;i<12;i++){
      for(int j=0;j<slots;j++){
        if(faturas[i,j] != 0){
          Console.WriteLine("Mês: {0} ---- Compra: {1} --- Valor {2}",i+1,j+1,faturas[i,j]);
        }
      }
    }
  }
}