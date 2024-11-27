// Matriz
string[,] dados = {
    {"Ralf", "Curitiba"},
    {"Juliana", "Campinas"},
    {"Cleber", "Joinvile"},
    {"Marcela", "Londrina"}
};

// Exibir dados
// Console.WriteLine(dados[1, 0]);

foreach (string dado in dados)
{
    Console.WriteLine(dado);
}