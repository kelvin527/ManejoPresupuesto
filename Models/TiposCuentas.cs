﻿namespace ManejoPresupuesto.Models
{
    public class TiposCuentas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
    }
}
