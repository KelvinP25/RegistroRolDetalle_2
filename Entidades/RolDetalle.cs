using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RolDetalle_II.Entidades
{
    public class RolDetalle
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }


        public RolDetalle()
        {
            Id = 0;
            RolId = 0;
            PermisoId = 0;
            esAsignado = false;
        }
        public RolDetalle(int rolId, int permisoId, bool esasignado)
        {
            Id = 0;
            rolId = RolId;
            permisoId = PermisoId;
            esasignado = esAsignado;
        }
    }
}
