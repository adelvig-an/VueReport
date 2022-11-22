namespace BussinesLayer.Common.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) 
            : base($"Entyti \"{name}\" ({key}) not found.")
        { }
    }
}
