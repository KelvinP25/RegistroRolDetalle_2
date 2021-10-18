using RolDetalle_II.DAL;
using RolDetalle_II.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RolDetalle_II.BLL
{
    public class PermisoBLL
    {
        public static Permiso Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Permiso permiso;

            try
            {
                permiso = contexto.Permiso.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return permiso;
        }

        public static List<Permiso> GetPermisos()
        {
            List<Permiso> lista = new List<Permiso>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Permiso.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        public static List<Permiso> GetList(Expression<Func<Permiso, bool>> criterio)
        {
            List<Permiso> Lista = new List<Permiso>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Permiso.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
