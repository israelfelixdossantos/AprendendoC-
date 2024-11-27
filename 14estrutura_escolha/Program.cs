string linguagem = "HTML";


// Estrutura de escolha

switch (linguagem)
{
    case "HTML":
    Console.WriteLine("Linguagem de Marcação.");
    break;

    case "CSS":
    Console.WriteLine("Linguagem de estilos.");
    break;

    case "C#":
    Console.WriteLine("Linguagem de programação.");
    break;

    default:
    Console.WriteLine("Linguagem de desconhecida.");
    break;
};

// Expressão switch 

string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação", 
    "CSS"  => "Linguagem de estilo", 
    "C#"   => "Linguagem de programação", 
    _      => "Linguagem desconhecida" 
    
};

Console.WriteLine(retorno);
