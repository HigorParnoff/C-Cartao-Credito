using System;
using System.IO;
using System.Collections.Generic;

namespace Higor{
  class Cartao {
    private double limite;
    private int id;

    public Cartao (int l, int i) {
      limite = l;
      string line;
      bool exist = false;
      StreamReader id_arq;
      id_arq = File.OpenText("id.txt");
        while((line = id_arq.ReadLine) != null){
          if(ToInt(line) == id){
            exist = true;
          }
        }
      id_arq.Close();

      if(!exist){
        id = i;
        StreamWriter id_arquivo;
        id_arquivo = File.AppendText("id.txt")

          id_arquivo.WriteLine(i)

        id_arquivo.Close();
      }else{
        
      }
    }

    public void comprar (double valor){
      if(limite - valor >= 0){
        limite = limite - valor;
        Console.WriteLine("Compra efetuada com sucesso");

        StreamWriter fatura;
          fatura = File.AppendText("fatura.txt");

          fatura.WriteLine(valor);
        fatura.Close();

      } else{
        Console.WriteLine("Compra Recusada");
      }
    }

    public void listadeCompras(){
      Console.WriteLine("Fatura: ");
      string line;
      StreamReader fatura;
      fatura = File.OpenText("fatura.txt");

        while((line = fatura.ReadLine()) != null){  
          Console.WriteLine(line);  
        }  
  
      fatura.Close();
    }
    
    public double fecharFatura(){
      string line;
      double somatorio = 0;

      StreamReader fatura;
      fatura = File.OpenText("fatura.txt");

        while((line = fatura.ReadLine()) != null){  
          somatorio = somatorio + double.Parse(line); 
        }  
  
      fatura.Close();
      return somatorio;
    }

  }
}