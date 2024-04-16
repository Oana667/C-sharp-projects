class Program
{
    static void Main(string[] args)
    {
       

        int suma, produs, ContSir, i, MAritmetica;
        suma = 0;
        produs = 1;
        Console.WriteLine("introuceti numarul elementelor: ");
        ContSir = int.Parse(Console.ReadLine());
        float MGeometrica;
        Console.WriteLine("introuceti elementele: ");
        for (i=0;i<ContSir;i++)
        {
            int nr;
            nr = int.Parse(Console.ReadLine());
            suma=suma+nr;
            produs=produs+nr;
        }
        MAritmetica = suma / ContSir;
        MGeometrica = (float)Math.Pow(produs, (float)1 / ContSir);
        Console.WriteLine("media aritmetica este: "+ MAritmetica);
        Console.WriteLine("media geometrica este: " + MGeometrica);
    }
}