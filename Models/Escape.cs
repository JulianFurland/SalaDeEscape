static class Escape{
    static string[] incognitaSalas = {"res1"};
    static int estadoJuego = 0;
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        if(Sala == estadoJuego && incognitaSalas[Sala] == Incognita) return true;
        else return false;
    }
}