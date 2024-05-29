
public class Musica
{
    public Musica(Artista artista, string nome) {

        Artista = artista;
        Nome = nome;

    }
   public string Nome {get;}
   public Artista Artista {get; }
   public int Duracao {get; set;}
   public bool Disponivel {get; set;}

   public Genero Genero {get; set;}
   //lambda
      public string DescricaoResumida =>
       $"A música {Nome} pertence a banda {Artista}.";
   //{ 
        // get{

        // return $"A música {Nome} pertence a banda {Artista}";
    
        //   }
        //                            };

   public void ExibirFicha(){
    System.Console.WriteLine($"Nome: {Nome}");
    System.Console.WriteLine($"Artista: {Artista.Nome}");
    if(Disponivel){
        System.Console.WriteLine("Disponivel no plano.");
    }else {
        System.Console.WriteLine("Não disponível no plano");
    }
    System.Console.WriteLine($"Tempo de Duração: {Duracao}");
    System.Console.WriteLine($"Disponíve no Plano: {Disponivel}");
   }

   public void ExibirNomeArtista(){
    System.Console.WriteLine($"{Nome} - {Artista}");
   }
}
