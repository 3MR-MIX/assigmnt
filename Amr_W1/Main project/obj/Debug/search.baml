   M S B A M L   `   `   `  ����G  CMain project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Main_projectMain_project  5          Main_project.search   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Main_project     5        N� Title$  search��5	      .��5      � 
������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	data_grid��5      $	��231��6'   $	��Top=�64      AutoGenerateColumns .  $��10,207,10,0q�6i      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
userr_name+6X     5      $ Phone number��6%    6;   �� *user_number+6]     5      $ Gender��6%    65   �� *user_gender+6W   5      �� 5   
   -   5         ��Name$ t1��5      $
��Left=�6   $��
137,57,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6b   $	��237��6z   $��27��6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $��
447,61,0,0q�6=   $	��Top=�6Q   $��23��6i   $��68��6u   6�   5      5      