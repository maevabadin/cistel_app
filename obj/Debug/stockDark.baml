   M S B A M L   `   `   `  ����I  Ecistel_elec_ge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:cistel_elec_gecistel_elec_ge  5          cistel_elec_ge.stockDark   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <controls'using:Microsoft.Toolkit.Uwp.UI.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:cistel_elec_ge     5        N� Title$  stock��5
       N� 
Background
 �   �$��Stretch=�5      $��Stretch=�6%   .��5      � ���	#FF355E8A.+�5   
   �� $��36(�5      $��Center=�5      $	��Top=�5      $��0,30,0,0q�5      
�������Stock5   '   �� 5   
   -   5         ��Name$ searchBarText��5      $
��Left=�5      $��	39,37,0,0q�5       �� TextWrapping$
 Wrap=�5      $��	Recherche��5      $	��Top=�5      $	��347��5      $��34��6   
�������$��0,0,0,2q�5       $��20(�5!      
���������5      Z�  �� SelectionBrush 5      Z� 5!      �� 5"   
   -   5         ��Name$ searchBarButton��5#      $��Q��5$      $
��Left=�5%      $��
405,34,0,0q�5&      $	��Top=�5'      $��40��5(      $��40��6   $��20(�5)      ���	#FF355E8A$��2q�5,      
���������5+      Z� 5,   !   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ stockDatagrid��5/      ���	#FFA4BAD2$��Disabled=�51      $	��500��52      $	��Top=�53      $��Center=�54         MinRowHeight$ 40Q�55         CanUserResizeColumns .  	   CanUserResizeRows	 .  
   CanUserAddRows
 .    CanUserDeleteRows . $��20(�5:      $��	0,100,0,0q�62   ��6   Z�  � 	Resources 5<      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%,  '        7 �� 5=      8   "  5?      .�5@      ��  � �� �	#FFF0F9FF63   �� 5A       � ��
 �   �63   �� 5B       � ��
 �   �64   �� 5C       � ��$ 40��6/   �� 5D       � ��$ Center=�6C   �� 5E       �@�Cursor$
 Hand��6/   5F      5G         Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��5K         
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 960 5N      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5L      �� *Description+5N        5P      $
 Prix��5Q       . $	 120 5T       5R      �� *Prix+5T        5V      $ 	Quantité��5W       . $	 120 5Z       5X      �� *
Quantite+5Z        5\      $ Qté Min��5]       . $	 120 5`       5^      �� *QteMin+5`        5c      $
 Etat��5d       . $	 120 5g       5e      �� *Etat+5g      4  .System.Windows.Controls.DataGridTemplateColumn  5j      $ 50 6)   $ V��64      CellTemplate 5k      �� 5l      .R�5m      �� $��50��5n   !   $
��Left=�5o   !   .��6<   V6?   5p      5r        5t      $ 50 6)   $ X��64    5u      �� 5v      .R�5w      �� $��50��5x   !   $
��Left=�5y   !   .��6<   X6?   5z      5|      5~      �� 5�   
   -   5        $ descriptionAddInput��5�      $
��Left=�5�      $��
30,640,0,0q�5�      $
 Wrap=�5�      $��Description��5�      $	��Top=�5�      $	��770��5�      $��32��6   
�������$��0,0,0,2q�5�      $��20(�5�      
���������5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ priceAddInput��5�      $
��Left=�5�      $��840,640,0,0q�5�      $
 Wrap=�5�      $
��Prix��5�      $	��Top=�5�      $	��200��5�      $��34��6   
�������$��0,0,0,2q�5�      $��20(�5�      
���������5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ quantityAddInput��5�      $
��Left=�5�      $��1110,640,0,0q�5�      $
 Wrap=�5�      $��	Quantité��5�      $	��Top=�5�      $	��200��5�      $��34��6   
�������$��0,0,0,2q�5�      $��20(�5�      
���������5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ minQuantityAddInput��5�      $
��Left=�5�      $��1370,640,0,0q�5�      $
 Wrap=�5�      $��Quantité Minimale��5�      $	��Top=�5�      $	��200��5�      $��34��6   
�������$��0,0,0,2q�5�      $��20(�5�      
���������5�      Z�  5�      Z� 5�      �� 5�   
   -   5        $ addItemButton��5�      $��Ajouter��5�      $��Center=�5�      $��	0,700,0,0q�5�      $	��Top=�5�      $	��118��5�      $��40��6   $��20(�5�      ���	#FF355E8A���	#FFF0F9FF$��2q�5�      
�������6!   5�      5�      