namespace _3__LiskovSubstitutionPrinciple.Animal
{
    public class Bird : Animal
    {
        public override string MakeNoise()
        {
            return "Chirp";
        }

        public override string Fly()
        {
            return "Flag wings";
        }
    }
}