public class Episodio{

    private List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo, int duração)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duração;
    }
    public int Ordem { get;  }

public string Titulo { get;  }

public int Duracao { get;  }

public string Resumo => $"Ep:{Ordem} , Nome:{Titulo} , {Duracao}: min {string.Join(", ", convidados)}";

public void AdicionarConvidados( string convidado ){
    convidados.Add(convidado);
}
}