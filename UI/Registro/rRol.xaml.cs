using RolDetalle_II.BLL;
using RolDetalle_II.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RolDetalle_II.UI.Registro
{
    /// <summary>
    /// Interaction logic for rRol.xaml
    /// </summary>
    public partial class rRol : Window
    {
        Rol rol = new Rol();
        public rRol()
        {
            InitializeComponent();
            this.DataContext = rol;
            PermisosComboBox.ItemsSource = PermisoBLL.GetPermisos();
            PermisosComboBox.SelectedValuePath = "PermisoId";
            PermisosComboBox.DisplayMemberPath = "Descripcion";
        }
        private void Actualizar()
        {
            this.DataContext = null;
            this.DataContext = rol;
        }
        private void Limpiar()
        {
            this.rol = new Rol();
            this.DataContext = rol;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Rol role = RolBLL.Buscar(rol.RolId);

            return (role != null);
        }

        private bool ValidarGuardar()
        {
            bool esValido = true;
            if (DetalleDataGrid.Items.Count == 0)
            {
                esValido = false;
                MessageBox.Show("Ha ocurrido un error, Debe agregar roles", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Rol encontrado = RolBLL.Buscar(rol.RolId);

            if (encontrado != null)
            {
                rol = encontrado;
                Actualizar();
                int totalp = RolBLL.Total(rol);
                string TotalPermiso = totalp.ToString();
                TotalTextBlock.Text = TotalPermiso;
            }
            else
            {
                Limpiar();
                MessageBox.Show("Rol no existe en la base de datos", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            rol.esActivo = false;
            rol.Detalle.Add(new RolDetalle
            {
                Id = rol.RolId,
                PermisoId = (int)PermisosComboBox.SelectedValue,
                esAsignado = ActivoCheckBox.IsChecked.Value


            });

            Actualizar();
            int totalp = RolBLL.Total(rol);
            string TotalPermiso = totalp.ToString();

            TotalTextBlock.Text = TotalPermiso;
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                rol.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Actualizar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarGuardar())
                return;
            bool paso = false;

            if (rol.RolId == 0)
            {
                paso = RolBLL.Guardar(rol);
            }
            else
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    paso = RolBLL.Guardar(rol);
                }
                else
                {
                    MessageBox.Show("No existe en la base de datos", "ERROR");
                }
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Fallo al guardar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Rol existe = RolBLL.Buscar(rol.RolId);

            if (existe == null)
            {
                MessageBox.Show("No existe la tarea en la base de datos", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                RolBLL.Eliminar(rol.RolId);
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }
    }
}
