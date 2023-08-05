namespace lesson6_oop_adv
{
    public interface IAnimalFactory
    {
        bool HasFur { get; set; }
        int NumberOfLegs { get; set; }

        int Run();
    }
}