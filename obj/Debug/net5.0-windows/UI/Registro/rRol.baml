   M S B A M L   `   `   `  ����H  DRolDetalle_II, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:RolDetalle_II.UI.RegistroRolDetalle_II.UI.Registro  5   	   $    RolDetalle_II.UI.Registro.rRol   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:RolDetalle_II.UI.Registro     5   	     � Title$
  rRol��5   	   $	��390��6   $	��500��6#   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��10q�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Rol Id: ��6   �� 5      -   5         ��Name$ RolIdTextBox��5      $��20��64   $	��150��6@   $��32,0,0,0q�6c   ��6L   �� *RolId+6c   �� 5      -   5         ��Name$ BuscarButton��5      $	��5,0q�63   $��20��6@   $��30��6L   .��5      �� $,��&/Resources/search_locate_find_6278.png��6    5      �� 5      $��90, 7q�6!   .+�5      �� -   5         ��Name$ ActivoCheckBox��5   #   $��Activo��6;    d� 	IsChecked 6L   �� *
esActivo+5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Descripcion: ��6   �� 5      -   5        $ DescripcionTextBox��5      $��20��6:   $	��350��6F   ��6R   �� *Descripcion+5      �� 5      $ Vertical=�6   $
��0,10q�64   .+�5      �� $��0q�6!   .+�5!      �� $ 
Horizontal=�6%   .+�5"      �� $��Permiso:��6$   �� 5#      -   5         ��Name$ PermisosComboBox��5#   '   $	��350��6A   $
��23,0q�6N   $��25��6\   5$      �� 5&      $ 
Horizontal=�6%   $
��0,10q�6>   $��Center=�6L   .+�5'      �� -   5        $ AgregarFilaButton��5'   %   $
��10,0q�6@   $	��100��6n   .��5(   "   �� $ 
Horizontal=�6-   .+�5*   &   �� $Q��K/Resources/1904677-add-addition-calculate-charge-create-new-plus_122527.png��6,   $��20��6�   �� 5+   &   $��Agregar fila��6,   5,   #   5-      �� 5.      -   5        $ RemoverFilaButton��5.   %   $
��10,0q�6@   $	��100��6n   .��5/   "   �� $ 
Horizontal=�6-   .+�50   &   �� $P��J/Resources/1904654-cancel-close-cross-delete-reject-remove-stop_122504.png��6,   $��20��6�   �� 52   &   $��Eliminar fila��6,   53   #   54      55      &   System.Windows.Controls.DataGrid  57      -   5          Name$ DetalleDataGrid��57   #   $��80��6]      AutoGenerateColumns$ False��6i   $	��430��6�   ��6=   �� *	Detalle+	   Columns	 58      0  *System.Windows.Controls.DataGridTextColumn  59   "   ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Permiso Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	PermisoId+  5:   "   $
 Es Asignado��65    6J   �� *
esAsignado+5<      5>      5@      �� 5B      $ 
Horizontal=�6   $��Center=�66   .+�5C      �� $"��Cantidad permisos agregados:��6   �� 5D      -	   5         ��Name$ TotalTextBlock��5D       $��20��68   5E      �� 5G      $ 
Horizontal=�6   $
��0,15q�66   $��Center=�6D   .+�5I      �� -
   5        $ NuevoButton��5I      $	��5,0q�62   .��5J      �� $ 
Horizontal=�6%   .+�5K      �� $I��C/Resources/1486485588-add-create-new-math-sign-cross-plus_81186.png��6$   $��20��6q   �� 5M      $��Nuevo��6$   5N      5O      �� 5P      -   5        $ GuardarButton��5P      $	��5,0q�66   .��5Q      �� $ 
Horizontal=�6%   .+�5R      �� $5��//Resources/savedisk_floppydisk_guardar_1543.png��6$   $��20��6]   �� 5T      $��Guardar��6$   5U      5V      �� 5W      -   5        $ EliminarButton��5W      $	��5,0q�66   .��5X      �� $ 
Horizontal=�6%   .+�5Y      �� $!��/Resources/delete_40623.png��6$   $��20��6I   �� 5[      $��Eliminar��6$   5\      5]      5^      5_      5`      5a      5b      