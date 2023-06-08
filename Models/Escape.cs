static class Escape{
    static string[] incognitaSalas = {"30", "carajo", "cañon","el nombre"};
    static int estadoJuego = 1;
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        if(Sala == estadoJuego && incognitaSalas[Sala - 1] == Incognita.ToLower()){
          estadoJuego++;
          return true;  
        } 
        else return false;
    }
}