namespace ClassLibraryExpression
{
    public abstract class Expression
    {
        public abstract int Evalue();

        public abstract String FormatGauche();


        public String Format()
        {
            return this.FormatGauche()  + " = " + this.Evalue().ToString();   
        }
       
        
    }
}