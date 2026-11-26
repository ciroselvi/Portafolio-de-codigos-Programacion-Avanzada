using System;

namespace Actividad_17;

public class Tanque
{
    public int Nivel { get; }
    public int Temperatura { get; }

    public Tanque(int nivel, int temperatura)
    {
        if (nivel < 0 || nivel > 100)
            throw new ArgumentOutOfRangeException(nameof(nivel));

        if (temperatura < 0 || temperatura > 100)
            throw new ArgumentOutOfRangeException(nameof(temperatura));

        Nivel = nivel;
        Temperatura = temperatura;
    }

    private bool NivelBajo => Nivel < 20;
    private bool TemperaturaAlta => Temperatura > 60;
    public bool TieneAlerta => NivelBajo || TemperaturaAlta;

    public string ObtenerEstado()
    {
        if (NivelBajo && TemperaturaAlta)
            return "ALERTA: NIVEL BAJO Y TEMPERATURA ALTA";
        if (NivelBajo)
            return "ALERTA: NIVEL BAJO";
        if (TemperaturaAlta)
            return "ALERTA: TEMPERATURA ALTA";
        return "NORMAL";
    }
}