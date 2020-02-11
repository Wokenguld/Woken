namespace MMLogoDrawer
{
    public interface ILogoGenerator
    {
        public string Logo { get; }
        public void Generate(int thicknessParameter);
        
    }
}