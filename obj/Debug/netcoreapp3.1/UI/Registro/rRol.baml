   M S B A M L   `   `   `  ����H  DRolDetalle_II, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:RolDetalle_II.UI.RegistroRolDetalle_II.UI.Registro  5   	   $    RolDetalle_II.UI.Registro.rRol   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:RolDetalle_II.UI.Registro     5   	     � Title$
  rRol��5   	   $	��390��6   $	��500��6#   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��10q�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Rol Id: ��6   �� 5      -   5         ��Name$ RolIdTextBox��5      $��20��64   $	��150��6@   $��32,0,0,0q�6c   ��6L   �� *RolId+6c   �� 5      -   5         ��Name$ BuscarButton��5      $	��5,0q�63   $��20��6@   $��30��6L   5      �� 5      $��90, 7q�6!   .+�5      �� -   5         ��Name$ ActivoCheckBox��5   #   $��Activo��6;    d� 	IsChecked 6L   �� *
esActivo+5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Descripcion: ��6   �� 5      -   5        $ DescripcionTextBox��5      $��20��6:   $	��350��6F   ��6R   �� *Descripcion+5      �� 5      $ Vertical=�6   $
��0,10q�64   .+�5      �� $��0q�6!   .+�5!      �� $ 
Horizontal=�6%   .+�5"      �� $��Permiso:��6$   �� 5#      -   5         ��Name$ PermisosComboBox��5#   '   $	��350��6A   $
��23,0q�6N   $��25��6\   5$      �� 5&      $ 
Horizontal=�6%   $
��0,10q�6>   $��Center=�6L   .+�5'      �� -   5        $ AgregarFilaButton��5'   %   $
��10,0q�6@   $	��100��6n   .��5(   "   �� $ 
Horizontal=�6-   .+�5)   &   �� $��Agregar fila��6,   5*   #   5+      �� 5,      -   5        $ RemoverFilaButton��5,   %   $
��10,0q�6@   $	��100��6n   .��5-   "   �� $ 
Horizontal=�6-   .+�5.   &   �� $��Eliminar fila��6,   5/   #   50      51      &   System.Windows.Controls.DataGrid  53      -   5          Name$ DetalleDataGrid��53   #   $��80��6]      AutoGenerateColumns$ False��6i   $	��430��6�   ��6=   �� *	Detalle+	   Columns	 54      0  *System.Windows.Controls.DataGridTextColumn  55   "   ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Permiso Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	PermisoId+  56   "   $
 Es Asignado��65    6J   �� *
esAsignado+58      5:      5<      �� 5>      $ 
Horizontal=�6   $��Center=�66   .+�5?      �� $"��Cantidad permisos agregados:��6   �� 5@      -	   5         ��Name$ TotalTextBlock��5@       $��20��68   5A      �� 5C      $ 
Horizontal=�6   $
��0,15q�66   $��Center=�6D   .+�5E      �� -
   5        $ NuevoButton��5E      $	��5,0q�62   .��5F      �� $ 
Horizontal=�6%   .+�5H      �� $��Nuevo��6$   5I      5J      �� 5K      -   5        $ GuardarButton��5K      $	��5,0q�66   .��5L      �� $ 
Horizontal=�6%   .+�5N      �� $��Guardar��6$   5O      5P      �� 5Q      -   5        $ EliminarButton��5Q      $	��5,0q�66   .��5R      �� $ 
Horizontal=�6%   .+�5T      �� $��Eliminar��6$   5U      5V      5W      5X      5Y      5Z      5[      