namespace CapaLogica
{
    public class logBoleta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logBoleta _instancia = new logBoleta();
        //privado para evitar la instanciación directa
        public static logBoleta Instancia
        {
            get
            {
                return logBoleta._instancia;
            }
        }
        #endregion singleton

    }
}
