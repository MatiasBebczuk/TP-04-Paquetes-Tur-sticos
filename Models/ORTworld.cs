class ORTworld{
    public static List < string > ListaDestinos {get; private set;}  = new List<string>{"BUENOS AIRES, ARGENTINA", "PORTO, BRASIL", "PARIS, FRANCIA", "MADRID, ESPAÑA", "NEW YORK, USA", "MOSCÚ, RUSIA", "CASABLANCA, MARRUECOS", "MONTEVIDEO, URUGUAY", "ROMA, ITALIA", "ATENAS, GRECIA"};
    public static List < string > ListaHoteles {get; private set;} = new List<string>{"hotelBuenosAires.jpg","hotelPorto.jpg", "hotelParis.jpg", "hotelMadrid.jpg", "hotelNewYork.jpeg", "hotelMoscu.jpeg","hotelCasaBlanca.jpg", "hotelMontevideo.jpg", "hotelRoma.jpg", "hotelAtenas.jpeg"};
    public static List< string > ListaAereos {get; private set;} = new List<string>{"AerolineasArgentinas.png", "aeromexico.png", "AmericanAirlines.png", "flybondi.png", "JetSmart.png", "LADE.png", "Lufthansa.png", "qatarairlines.png", "turkishairlines.png", "unitedairlines.png"};
    public static List< string > ListaExcursiones {get; private set;} = new List<string>{"bsasExc.jpeg", "portoExc.jpeg", "parisExc.jpeg", "madridExc.jpeg", "newExc.jpeg", "moscuExc.jpeg", "casabExc.jpeg", "montevExc.jpeg", "romaExc.jpeg", "greciaExc.jpeg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool existe = Paquetes.Keys.Contains(destinoSeleccionado);
        if(!existe){
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return existe;
    }
}