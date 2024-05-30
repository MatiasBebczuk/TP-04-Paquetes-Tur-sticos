class ORTworld{
    public static List < string > ListaDestinos {get; private set;}
    public static List < string > ListaHoteles {get; private set;}
    public static List< string > ListaAereos {get; private set;}
    public static List< string > ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public ORTworld (){
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

        ListaHoteles.Add("hotelAtenas.jpeg");
        ListaHoteles.Add("hotelBuenosAires.jpg");
        ListaHoteles.Add("hotelCasaBlanca.jpg");
        ListaHoteles.Add("hotelMadrid.jpg");
        ListaHoteles.Add("hotelMontevideo.jpg");
        ListaHoteles.Add("hotelMoscu.jpeg");
        ListaHoteles.Add("hotelNewYork.jpeg");
        ListaHoteles.Add("hotelParis.jpg");
        ListaHoteles.Add("hotelPorto.jpg");
        ListaHoteles.Add("hotelRoma.jpg");
        
        ListaAereos.Add("AerolineasArgentinas.png");
        ListaAereos.Add("aeromexico.png");
        ListaAereos.Add("AmericanAirlines.png");
        ListaAereos.Add("flybondi.png");
        ListaAereos.Add("JetSmart.png");
        ListaAereos.Add("LADE.png");
        ListaAereos.Add("Lufthansa.png");
        ListaAereos.Add("qatarairlines.png");
        ListaAereos.Add("turkishairlines.png");
        ListaAereos.Add("unitedairlines.png");

        ListaExcursiones.Add("bsasExc.jpeg");
        ListaExcursiones.Add("casabExc.jpeg");
        ListaExcursiones.Add("greciaExc.jpeg");
        ListaExcursiones.Add("madridExc.jpeg");
        ListaExcursiones.Add("montevExc.jpeg");
        ListaExcursiones.Add("moscuExc.jpeg");
        ListaExcursiones.Add("newExc.jpeg");
        ListaExcursiones.Add("parisExc.jpeg");
        ListaExcursiones.Add("portoExc.jpeg");
        ListaExcursiones.Add("romaExc.jpeg");
        
    }
    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool existe = Paquetes.Keys.Contains(destinoSeleccionado);
        if(!existe){
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return existe;
    }

}