//Lambda
// See https://aka.ms/new-console-template for more information

//Delegate function
using System.Runtime.CompilerServices;

int Filtre1( int v)
{
    if (v < 0)
    {
        return 0;
    }
    return v;
}

int Operation(int a, int b, Func<int, int> f, [CallerArgumentExpression("f")] string? nom_param = null)
{
    a = f(a);
    b = f(b);

    //CallerArgumentExpression
    Console.WriteLine("Filtrage Function " + nom_param);
    
    return a + b;

}

//Func<int, int> limité a cs9
//condition[v > 10] ? return[v] : else[10]
Func<int, int> Filtre2 = (int v) => v < 10 ? v : 10;

//Plus obligé de donner le type des lambda en cs10
var Filtre3 = (int v) => v < 10 ? v : 10;

//Il est possible d'ajouter un type à la valeur de retour qu'on attend
var Filtre4 = string (int v) => null;

Console.WriteLine(Operation(-1,15, Filtre2));
