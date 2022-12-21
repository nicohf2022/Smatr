using System;
using System.Collections.Generic;

namespace AdapterExample;

/// <summary>
/// Un adaptador de Plug a ISmartDevice.
/// </summary>

public class Adapter : ISmartDevice
{
    /// <summary>
    /// Crea un nuevo adaptador.
    /// </summary>
    /// <param name="plug">El plug a adaptar.</param>
    /// <returns>El adaptador recién creado.</returns>
    public Adapter(Plug plug)
    {
        this.plug = plug;
    }

    /// <summary>
    /// .
    /// </summary>
    /// <returns>El plug a adaptar.</returns>
    public Plug plug { get; }

    /// <summary>
    /// Enciende el dispositivo si estaba apagado.
    /// </summary>
    public void On()
    {
        if(plug.GetStatus()=="off")
        {
            this.plug.ToggleStatus();
        }
      
    }

    /// <summary>
    /// Apaga el dispositivo.
    /// </summary>
    public void Off()
    {
        if(plug.GetStatus()=="on")
        {
            this.plug.ToggleStatus();
        }
    }

    /// <summary>
    /// Retorna el status del dispositivo.
    /// </summary>
    public string GetStatus()
    {
        return this.plug.GetStatus();
    }

   
    


}