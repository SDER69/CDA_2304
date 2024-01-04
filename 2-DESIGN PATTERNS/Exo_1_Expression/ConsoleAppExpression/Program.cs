using ClassLibraryExpression;


namespace ConsoleAppExpression

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibraryExpression.Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            int resultat1 = exp1.Evalue();
            Console.WriteLine(exp1.Format());

            ClassLibraryExpression.Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33),new Nombre(11)));
            int resultat2 = exp2.Evalue();
            Console.WriteLine(exp2.Format());

            ClassLibraryExpression.Expression exp3 = new Soustraction(new Nombre(33), new Nombre(33));
            int resultat3 = exp3.Evalue();
            Console.WriteLine(exp3.Format());

            ClassLibraryExpression.Expression exp4 = new Soustraction(new Nombre(33), new Soustraction(new Nombre(33), (new Nombre(11))));
            int resultat4 = exp4.Evalue();
            Console.WriteLine(exp4.Format());
        }
    }
}