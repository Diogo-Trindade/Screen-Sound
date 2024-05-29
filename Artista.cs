public class Artista{

    public Artista(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album){
        albums.Add(album);
    }

    public void ExibirDiscografia(){
        System.Console.WriteLine($"Discografia do Artista: {Nome}");
        foreach(Album album in albums){
            System.Console.WriteLine($"Album: {album.Nome}");
        }
    }
}