static class Escape{
    static string[] incognitaSalas = {"res1"};
    static int estadoJuego = 1;
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        if(Sala == estadoJuego && incognitaSalas[Sala] == Incognita){
          estadoJuego++;
          return true;  
        } 
        else return false;
    }
}