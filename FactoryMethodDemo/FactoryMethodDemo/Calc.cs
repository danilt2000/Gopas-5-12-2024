namespace OpenCloseDemo
{
    public class Calc
    {
        public double Result { get; protected set; }
        public virtual void Plus(double x) => Result += x;

        
 
    }
}
