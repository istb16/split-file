   M S B A M L   `   `   `  ����E  Asplit-file, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:split_file
split_file  5   	       split_file.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:split_file     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��600��6)   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $	��100 �6   6-   �� 5      6!   �� 5      $
��Auto �6   6.    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   $��0��6$   $��分割するファイル��61   $
��Wrap=�6A   �� 5   
   -   5        $��tbFile��5   /   $��1��6   $��0��6"   6/   �� 5   
   -   5        $��btnSelectFile��5   =   $��2��6   $��0��6!   $
��20,5q�6.   .��6n   選択6r   �� 5   
   $��0��6   $��1��6$   $9��3分割後のファイルを保存するフォルダ��61   $
��Wrap=�6J   �� 5   
   -   5        $��tbOutFolder��5   /   $��1��6   $��1��6"   6/   �� 5   
   -   5        $��btnSelectFolder��5   =   $��2��6   $��1��6!   $
��20,5q�6.   .��6r   選択6v   �� 5   
   $��0��6   $��2��6$   $��方法��61   $
��Wrap=�6;   �� 5   
   -   5        $��tbDivNum��5   /   $��1��6   $��2��6"   $��1000000��6?    �� TextAlignment$ Right=�6N   �� 5   
   -   5        $��cbMethod��5   0   $��2��6   $��2��6#   .@�5       �� $��文字��6    �� 
IsSelected$
 True��6(   6<   �� 5!      $	��行��6   6)   5"      �� 5$   
   -   5        $��btnSplit��5$   =   $��1��6   $��3��6!   $
��20,5q�6.   .��6d   ファイル分割6l   5%      5&      