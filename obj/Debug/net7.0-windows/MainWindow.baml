   M S B A M L   `   `   `  ����B  >Squares, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SquaresSquares  5   	       Squares.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Squares     5   	     � Title$  Funny colored quares��5   	   $	��750��6&   $	��800��63   .��5	      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   .+�5   
   �� -   5         ��Name$ Button1��5      $��Button 1��6"   $��0��65   $��0��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button2��5      $��Button 2��6"   $��0��65   $��1��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button3��5      $��Button 3��6"   $��0��65   $��2��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button4��5      $��Button 4��6"   $��1��65   $��0��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button5��5      $��Button 5��6"   $��1��65   $��1��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button6��5      $��Button 6��6"   $��1��65   $��2��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button7��5      $��Button 7��6"   $��2��65   $��0��6B   $��5q�6R   6]   �� 5   
   -   5        $ Button8��5      $��Button 8��6"   $��2��65   $��1��6B   $��5q�6R   6]   �� 5   
   -	   5        $ Button9��5      $��Button 9��6"   $��2��65   $��2��6B   $��5q�6R   6]   �� 5    
   .+�5!      �� -
   5         ��Name$ Iterator��5!       �� Left$	 150��6(   
 �� Top$	 500��6:   $	��150��6K   $��30��6W   $,��&Количество нажатий: 0��6c   ��6�   Z� 6�   5"      �� 5#   
   .+�5$      �� -   5        $
 Temp��5$      $	 550��6$   $	 150��66   $	��190��6G   $��59��6S   $.��(Температура за бортом��6_   $
��Left=�6�   $��Center=�6�   ��6|   Z� 6�   5%      5&      5'      