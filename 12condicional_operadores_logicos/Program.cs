double valor 500;
string pagamento = "à vista";

if(valor >= 100 && pagamento == "à vista")
{
    Console.WriteLine(&"Desconto de 10%! Total a pagar é R${valor*0.9}");
}
else
{
    Console.WriteLine(&"O total a pagar é R${valor}");
}