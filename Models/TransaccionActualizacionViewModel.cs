﻿namespace ManejoPresupuestoV2.Models
{
    public class TransaccionActualizacionViewModel:TransaccionCreacionViewModel
    {
        public int CuentaAnteriorId { get; set; }

        public decimal MontoAnterior { get; set; }

        public string UrlRetorno { get; set;}
    }
}
