   M S B A M L   `   `   `  ����I  Ecistel_elec_ge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:cistel_elec_gecistel_elec_ge  5          cistel_elec_ge.stock   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <controls'using:Microsoft.Toolkit.Uwp.UI.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:cistel_elec_ge     5        N� Title$  stock��5
       N� 
Background
 �   �$��Stretch=�6(   $��Stretch=�6F   .��5      � ���	#FFF0F9FF.+�5   
   �� $��36(�5      $��Center=�5      $	��Top=�5      $��0,30,0,0q�5      
���   �Stock5   '   �� 5   
   -   5         ��Name$ searchBarText��5      $
��Left=�5      $��	39,37,0,0q�5       �� TextWrapping$
 Wrap=�5      $��	Recherche��5      $	��Top=�5      $	��347��5      $��34��6   
���   �$��0,0,0,2q�5      $��20(�5       ��5      Z�  �� SelectionBrush 5      Z� 5       �� 5!   
   -   5         ��Name$ searchBarButton��5"      $��Q��5#      $
��Left=�5$      $��
405,34,0,0q�5%      $	��Top=�5&      $��40��5'      $��40��6   $��20(�5(      ���	#FFF0F9FF$��2q�5+      ��5*      Z� 5+      &   System.Windows.Controls.DataGrid  5-   
   -   5          Name$ stockDatagrid��5.      ���	#FFA4BAD2$��Disabled=�50      $	��500��51      $	��Top=�52      $��Center=�53         MinRowHeight$ 40Q�54         CanUserResizeColumns .  	   CanUserResizeRows	 .  
   CanUserAddRows
 .    CanUserDeleteRows . $��20(�59      $��	0,100,0,0q�62   ��6   Z�  � 	Resources 5;      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%,  '        7 �� 5<      8   "  5>      .�5?      ��  � �� �	#FF355E8A63   �� 5@       � ��
 �����63   �� 5A       � ��
 �   �64   �� 5B       � ��$ 40��6/   �� 5C       � ��$ Center=�6C   �� 5D       �@�Cursor$
 Hand��6/   5E      5F         Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��5J         
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 960 5M      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5K      �� *Description+5M        5O      $
 Prix��5P       . $	 120 5S       5Q      �� *Prix+5S        5U      $ 	Quantité��5V       . $	 120 5Y       5W      �� *
Quantite+5Y        5[      $ Qté Min��5\       . $	 120 5_       5]      �� *QteMin+5_        5b      $
 Etat��5c       . $	 120 5f       5d      �� *Etat+5f      4  .System.Windows.Controls.DataGridTemplateColumn  5i      $ 50 6)   $ V��64      CellTemplate 5j      �� 5k      .R�5l      �� $��50��5m   !   $
��Left=�5n   !   ���	#FF355E8A��5o   !   Z� ��5p   !   Z� .��5q   8   V6;   5r      5t        5v      $ 50 6)   $ X��64    5w      �� 5x      .R�5y      �� $��50��5z   !   $
��Left=�5{   !   ���	#FF355E8A��5|   !   Z� ��5}   !   Z� .��5~   8   X6;   5      5�      5�      �� 5�   
   -   5        $ descriptionAddInput��5�      $
��Left=�5�      $��
30,640,0,0q�5�      $
 Wrap=�5�      $��Description��5�      $	��Top=�5�      $	��770��5�      $��32��6   
���   �$��0,0,0,2q�5�      $��20(�5�      ��5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ priceAddInput��5�      $
��Left=�5�      $��840,640,0,0q�5�      $
 Wrap=�5�      $
��Prix��5�      $	��Top=�5�      $	��200��5�      $��34��6   
���   �$��0,0,0,2q�5�      $��20(�5�      ��5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ quantityAddInput��5�      $
��Left=�5�      $��1110,640,0,0q�5�      $
 Wrap=�5�      $��	Quantité��5�      $	��Top=�5�      $	��200��5�      $��34��6   
���   �$��0,0,0,2q�5�      $��20(�5�      ��5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ minQuantityAddInput��5�      $
��Left=�5�      $��1370,640,0,0q�5�      $
 Wrap=�5�      $��Quantité Minimale��5�      $	��Top=�5�      $	��200��5�      $��34��6   
���   �$��0,0,0,2q�5�      $��20(�5�      ��5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ addItemButton��5�      $��Ajouter��5�      $��Center=�5�      $��	0,700,0,0q�5�      $	��Top=�5�      $	��118��5�      $��40��6   $��20(�5�      ���	#FFF0F9FF���	#FF355E8A$��2q�5�      5�      5�      