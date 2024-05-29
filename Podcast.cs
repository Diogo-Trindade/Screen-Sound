public class Podcast{

private List<Episodio> episodios = new();
public Podcast(string nome, string host)
{
    Nome = nome;
    Host = host;
}

public string Nome { get;}
public string Host { get;}

public int TotalEpisodios => episodios.Count;

public void AdicionarEpisodio(Episodio episodio){
    episodios.Add(episodio);
}

public void ExibirDetalhes(){
    System.Console.WriteLine($"Podcast{Nome}, Apresentado por {Host} \n");

    foreach (Episodio episodio in episodios.OrderBy(e=>e.Ordem)){
        System.Console.WriteLine("Resumo do Episódio" + episodio.Resumo);
    };

    System.Console.WriteLine($"Total de episodios  : {TotalEpisodios}");
}

}