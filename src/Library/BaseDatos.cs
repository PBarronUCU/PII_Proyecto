namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public sealed class BaseDatos
    {
        private static readonly BaseDatos _instance = new BaseDatos();
        
        
        private BaseDatos()
        {
        }
        
        public static BaseDatos Instance
        {
            get { return _instance; }
        }
        
    }
}