using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Business
{
    class ente
    {
        int id;
        List<entedireccion> direciones;
        List<entetelefono> telefonos;
        List<contacto> contactos;
        int tipo;

    }

    class cliente
    {
        int id;
        ente ente;

        int compania;
        int empresa;
        int sucursal;
    }
    class proveedor
    {
        int id;
        ente ente;

        int compania;
        int empresa;
        int sucursal;
    }
    class contacto
    {
        int id;
        int idEnteRelacionado;
        ente ente;
    }


    class entedireccion
    {
        int id;
        int enteid;
    }
    class entetelefono
    {
        int id;
        int enteid;
    }


    class movimientoCaja
    {
        decimal importe;
        int enteId;

        int usuarioId;

               
    }



}
