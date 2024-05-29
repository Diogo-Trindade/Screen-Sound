    public class Album{

        public Album(string nome)
        {
            Nome = nome;
        }
        private List<Musica> musicas = new();
        public string Nome { get;  }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica){
            musicas.Add(musica);
        }

        public void ExibirMusicasAlbum(){
            System.Console.WriteLine("Lista das músicas: \n");
            foreach(var musica in musicas){

            System.Console.WriteLine($"Musica: {musica.Nome}");
            }
            System.Console.WriteLine($"\nDuração total do album: {DuracaoTotal}");

        }
    }