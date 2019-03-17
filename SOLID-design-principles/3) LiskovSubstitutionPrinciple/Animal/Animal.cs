namespace _3__LiskovSubstitutionPrinciple.Animal
{
    public abstract class Animal
    {
        public string Walk()
        {
            return "Move feet";
        }

        public string Run()
        {
            return "Move feet quickly";
        }

        public virtual string Fly()
        {
            return null;
        }

        public virtual string MakeNoise()
        {
            return null;
        }
    }
}