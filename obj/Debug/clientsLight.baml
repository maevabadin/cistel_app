   M S B A M L   `   `   `  ����I  Ecistel_elec_ge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:cistel_elec_gecistel_elec_ge  5      !    cistel_elec_ge.clientsLight   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:cistel_elec_ge     5        N� Title$  clientsLight��5	      .��5
      � .+�5   
   �� ���#F0F9FF$
��Left=�5      $	��Top=�5      $	��840��5      $
��1600��5      �� 5   
   $��Mes clients��5      $��Center=�5      $	��Top=�5      $��60��5      $	��160��5      $��0,60,0,0q�5      ���#355E8A$��Segoe UI)�5      $��30(�5      �� 5   
   ���#355E8A$
��Left=�5!      $	��Top=�5"      $��30��5#      $��90��5$      $��400,161,0,0q�5%      �� 5'   
   -   5        $��clientLabel��5)      $��Client :��5(      $
��Left=�5*      $	��Top=�5+      $��30��5,      $��90��5-      $��400,161,0,0q�5.      $��Segoe UI)�5/      $��15(�50      ���#FFFFFF51      �� 53   
   -   5        $��	searchBox��54      $
��Left=�55      $	��Top=�56      $��30��57      $	��620��58      $��495,161,0,0q�59      $��Segoe UI)�5:      $��15(�5;      �� 5=   
   -   5        $��searchButton��5@      ���#355E8A$��	Recherche��5?      $
��Left=�5A      $	��Top=�5B      $��30��5C      $��80��5D      $��1120,160,0,0q�5E      $��Segoe UI)�5F      $��15(�5G      ���#FFFFFF5H      &   System.Windows.Controls.DataGrid  5L   
   -   5          Name$ clientsDatagrid��5M      ���#FFFFFF$��Disabled=�5O      $��Center=�5P      $	��Top=�5Q      $��	0,250,0,0q�5R      $	��500��5S      $
��1400��5T         MinRowHeight$ 40Q�5U         CanUserResizeColumns .     CanUserResizeRows .     CanUserAddRows .    CanUserDeleteRows . $��20(�5Z      ��5[      Z�    Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$ 
N° client��5`      	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 5c      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5a      �� *client_number+5c        5e      $	 Nom��5f      	 . $	
 150 5i       5g      �� *
lastname+5i        5k      $ Prénom��5l      	 . $	
 150 5o       5m      �� *	firstname+5o        5q      $ Adresse��5r      	 . $	
 200 5u       5s      �� *	address+5u        5w      $ CP��5x      	 . $	
 100 5{       5y      �� *
zip_code+5{        5}      $ Ville��5~      	 . $	
 150 5�       5      �� *city+5�        5�      $ Téléphone��5�      	 . $	
 150 5�       5�      �� *telephone_number+5�        5�      $ Email��5�      	 . $	
 200 5�       5�      �� *email+5�      5�      5�      5�      