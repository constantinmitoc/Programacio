namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vendesMarta, vendesPere, vendesJoan;
            bool condicio;

            condicio = vendesMarta > vendesJoan && vendesMarta > vendesPere;

            condicio = vendesMarta > 20000 && vendesPere > 20000 && vendesJoan > 20000;

            condicio = vendesMarta < 5000 || vendesPere < 5000 || vendesJoan < 5000;

            condicio = (vendesMarta + vendesPere + vendesJoan) / 3 > 8000;
            
            condicio = ((vendesMarta + vendesPere + vendesJoan) / 3 > 8000) ||
                vendesMarta < 5000 || vendesPere < 5000 || vendesJoan < 5000;

            condicio = vendesMarta > vendesPere && vendesJoan > vendesPere;
        }
    }
}
