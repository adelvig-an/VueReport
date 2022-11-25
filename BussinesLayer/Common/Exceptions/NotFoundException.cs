namespace BussinesLayer.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) 
            : base($"Entyti \"{name}\" ({key}) not found.")
        { }
    }
}
