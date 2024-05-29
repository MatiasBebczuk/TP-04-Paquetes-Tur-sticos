class ORTworld{
    public static List < string > ListaDestinos {get; private set;}
    public static List < string > ListaHoteles {get; private set;}
    public static List< string > ListaAereos {get; private set;}
    public static List< string > ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public ORTworld (List<string> listadestinos, List<string> listahoteles, List<string> listaereos, List<string> listaexcursiones, Dictionary <string, Paquete> paquetes){
        ListaDestinos = listadestinos;
        ListaHoteles = listahoteles;
        ListaAereos = listaereos;
        ListaExcursiones = listaexcursiones; 
        Paquetes = paquetes;

        ListaDestinos.Add("BUENOS AIRES, ARGENTINA");
        ListaDestinos.Add("PORTO, BRASIL");
        ListaDestinos.Add("PARIS, FRANCIA");
        ListaDestinos.Add("MADRID, ESPAÑA");
        ListaDestinos.Add("NEW YORK, USA");
        ListaDestinos.Add("MOSCÚ, RUSIA");
        ListaDestinos.Add("CASABLANCA, MARRUECOS");
        ListaDestinos.Add("MONTEVIDEO, URUGUAY");
        ListaDestinos.Add("ROMA, ITALIA");
        ListaDestinos.Add("ATENAS, GRECIA");
    }
    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool existe = Paquetes.Keys.Contains(destinoSeleccionado);
        if(!existe){
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return existe;
    }

}