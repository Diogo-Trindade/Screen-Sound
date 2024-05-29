// //screen sound

using System.Security.Cryptography.X509Certificates;

string mensagemBoasVindas = "\nBem vindo ao Screen Sound!";
// List<String> bandas = new List<String>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMensagem(){
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
System.Console.WriteLine(mensagemBoasVindas);

}
void ExibirOpcao(){
Console.WriteLine("\nEscolha uma das opções a seguir: ");
Console.WriteLine("\n1 Registrar Banda");
Console.WriteLine("2 listar Banda");
Console.WriteLine("3 Avaliar banda");
Console.WriteLine("4 Média das avaliações");
Console.WriteLine("5 Para Excluir");
System.Console.WriteLine("6 Para sair");
Console.Write("Opção: ");

string opcaoEscolhida = Console.ReadLine()!;
int opcaoNumerada = int.Parse(opcaoEscolhida);
    switch (opcaoNumerada){
        case 1:  SalvarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMedia();
            break;
        case 5: Excluir();
            break;
        case 6: Sair();
            break;
        default: Console.WriteLine("\nOpção Inexistente");
        break;
    }

}

void SalvarBanda()
{
    Console.Clear();
    ExibirTitulo("Registrar Banda");
    System.Console.WriteLine("Digite o nome da Banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
    Console.WriteLine("Carregando...");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMensagem();
    ExibirOpcao();
};

void ExibirBandas(){

    Console.Clear();
    Console.WriteLine("Carregando...");
    Thread.Sleep(2000);
    Console.Clear();

    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagem();
    ExibirOpcao();

};

void ExibirTitulo(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
  

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
};

void AvaliarBanda(){

    Console.Clear();
    ExibirTitulo("Avaliar banda:");
    Console.Write("Digite o nome da Banda:");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        System.Console.Write($"\nQual a nota que {nomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        System.Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("Carregando...");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMensagem();
        ExibirOpcao();
    } else {
        System.Console.WriteLine($"A banda {nomeDaBanda} não foi adicionada. ");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("Carregando...");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("\nAperte qualquer tecla para voltar! ... ");
        System.Console.ReadKey();
        Console.Clear();
       ExibirMensagem();
            ExibirOpcao();
    }

};

void ExibirMedia(){
    Console.Clear();
    ExibirTitulo("Avaliação Banda");
    Console.Write("Digite o nome da Banda:");
    string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda)){
            List<int> notasDasBandas = bandasRegistradas[nomeDaBanda];
            System.Console.WriteLine($"A média da Banda {nomeDaBanda} é: {notasDasBandas.Average()}");
            System.Console.WriteLine("Aperte qualquer tecla para voltar! ");
            System.Console.ReadKey();
        }else {
            System.Console.WriteLine($"A banda {nomeDaBanda} não foi adicionada");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Carregando...");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("\nAperte qualquer tecla para voltar ao menu! ... ");
            System.Console.ReadKey();
            Console.Clear();
            ExibirMensagem();
            ExibirOpcao();
        };

 
};

void Sair(){
    Console.Clear();
    Thread.Sleep(2000);
    Console.Write("Carregando...");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Adeus. Aperte ( CTRL+C ) para encerrar programa! ");
    System.Console.WriteLine("\nOu se quiser voltar aperte qualquer tecla: ...");
    System.Console.ReadKey();
    Console.Clear();
    Thread.Sleep(3000);
    Console.Write("Carregando...");
    Thread.Sleep(3000);
    Console.Clear();
    bandasRegistradas.Clear();
    Thread.Sleep(3000);
    ExibirCaveira();
    Thread.Sleep(3000);
    Console.Clear();
    Console.Write("Carregando...");
    Thread.Sleep(1000);
    ExibirMensagem();
    ExibirOpcao();

}

void Excluir(){
    Console.Clear();
    Console.Write("Carregando...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.Write("Digite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine()!;
     if(!bandasRegistradas.ContainsKey(nomeDaBanda)){
        System.Console.WriteLine($"A banda {nomeDaBanda} não foi adicionada! ");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("Carregando...");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("\nAperte qualquer tecla para voltar ao menu! ... ");
        System.Console.ReadKey();
        Console.Clear();
        ExibirMensagem();
        ExibirOpcao();
        System.Console.ReadKey();
        Console.Clear();
        ExibirOpcao();
        return;
       }
       bandasRegistradas.Remove(nomeDaBanda);
        System.Console.WriteLine("Banda excluida com sucesso! ");
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("Carregando...");
        Console.Clear();
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMensagem();
        ExibirOpcao();
}

void ExibirCaveira(){
    System.Console.WriteLine(@"                            
                            ,--.
                           {    }
                           K,   }
                          /  ~Y`
                     ,   /   /
                    {_'-K.__/
                      `/-.__L._
                      /  ' /`\_}
                     /  ' /
             ____   /  ' /
      ,-'~~~~    ~~/  ' /_
    ,'             ``~~~  ',
   (                        Y
  {                         I
 {      -                    `,
 |       ',                   )
 |        |   ,..__      __. Y
 |    .,_./  Y ' / ^Y   J   )|
 \           |' /   |   |   ||
  \          L_/    . _ (_,.'(
   \,   ,      ^^  ' / |      )
     \_  \          /,L]     /
       '-_~-,       ` `   ./`
          `'{_            )
              ^^\..___,.--`

 Suas músicas não estão mais aqui, mas bem vindo novamente
");
}

ExibirMensagem();
ExibirOpcao();



