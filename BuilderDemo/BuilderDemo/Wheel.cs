namespace BuilderDemo
{
    public class Wheel
    {
        private ITyre? tyre;

        public ITyre? Tyre { get => tyre;
            set {
                if (Rim is null) throw new NoRimException();
                if ((Rim is WideRim && value is SlimTyre) || Rim is SlimRim && value is WideTyre)
                    throw new BadTyreExeption();
                tyre = value;
            } 
        }

        public IRim? Rim { get; set; }

        public IList<Bolt> Bolts { get; set; } = new List<Bolt>();

        public override string ToString()
        {
            return $"Tyre {Tyre}; Rim: {Rim}, Bolts {Bolts.Count}";
        }
    }
}