   M S B A M L   `   `   `  ����G  CLab02-Task01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lab02_Task01Lab02_Task01  5   	       Lab02_Task01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lab02_Task01     5   	     � Title$  
Calculator��5   	   $	��650��6   $	��550��6)   .��5	      � 
���OO/� � RowDefinitions 5
   
   �� 5      $��1.25* �6   6-   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��4��6   
�����w�$��5q�6O    �� CornerRadius$ 10��6c   $��5q�6u   ._�5      �� -   5         ��Name$ txt_eq��5      $��50(�6&   67   5      �� 5   
   -   5         ��Name$ num_9��5      $��1��6    $��0��6-   $��9��6=   $��5q�5      $	��100��5      $��50(�5       
������� � 	Resources 5"       �� 
TargetType �� Property	 �� Value��%_   '��       �� 5#      " ��6   .�5$      ��  �@��CornerRadius$	 10��65   5%      5&      5'      �� 5(   
   -   5        $ num_8��5(      $��1��6    $��1��6-   $��8��6=   $��5q�5)      $	��100��5*      $��50(�5+      
������� 5-      ��%_   '��       �� 5.      " ��6   .�5/      ��  �@��CornerRadius$	 10��65   50      51      52      �� 53   
   -   5        $ num_7��53      $��1��6    $��2��6-   $��7��6=   $��5q�54      $	��100��55      $��50(�56      
������� 58      ��%_   '��       �� 59      " ��6   .�5:      ��  �@��CornerRadius$	 10��65   5;      5<      5=      �� 5>   
   -   5        $ num_divided��5>      $��1��6&   $��3��63   $��/��6C   $��5q�5?      $	��100��5@      $��50(�5A      
������� 5C      ��%_   '��       �� 5D      " ��6   .�5E      ��  �@��CornerRadius$	 10��65   5F      5G      5H      �� 5J   
   -   5        $ num_4��5J      $��2��6    $��0��6-   $��4��6=   $��5q�5K      $	��100��5L      $��50(�5M      
������� 5O      ��%_   '��       �� 5P      " ��6   .�5Q      ��  �@��CornerRadius$	 10��65   5R      5S      5T      �� 5U   
   -   5        $ num_5��5U      $��2��6    $��1��6-   $��5��6=   $��5q�5V      $	��100��5W      $��50(�5X      
������� 5Z      ��%_   '��       �� 5[      " ��6   .�5\      ��  �@��CornerRadius$	 10��65   5]      5^      5_      �� 5`   
   -   5        $ num_6��5`      $��2��6    $��2��6-   $��6��6=   $��5q�5a      $	��100��5b      $��50(�5c      
������� 5e      ��%_   '��       �� 5f      " ��6   .�5g      ��  �@��CornerRadius$	 10��65   5h      5i      5j      �� 5k   
   -	   5        $ num_multiple��5k      $��2��6'   $��3��64   $��*��6D   $��5q�5l      $	��100��5m      $��50(�5n      
������� 5p      ��%_   '��       �� 5q      " ��6   .�5r      ��  �@��CornerRadius$	 10��65   5s      5t      5u      �� 5w   
   -
   5        $ num_1��5w      $��3��6    $��0��6-   $��1��6=   $��5q�5x      $	��100��5y      $��50(�5z      
������� 5|      ��%_   '��       �� 5}      " ��6   .�5~      ��  �@��CornerRadius$	 10��65   5      5�      5�      �� 5�   
   -   5        $ num_2��5�      $��3��6    $��1��6-   $��2��6=   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ num_3��5�      $��3��6    $��2��6-   $��3��6=   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ num_sub��5�      $��3��6"   $��3��6/   $��-��6?   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ num_0��5�      $��4��6    $��0��6-   $��0��6=   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ num_dot��5�      $��4��6"   $��1��6/   $��.��6?   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ num_sum��5�      $��4��6"   $��2��6/   $��+��6?   $��5q�5�      $	��100��5�      $��50(�5�      
������� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      �� 5�   
   -   5        $ 	num_equal��5�      $��4��6$   $��2��61   $��3��6B   $��=��6R   $��20,10,18,10q�5�      $	��100��5�      $��50(�5�      
��� ��� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��65   5�      5�      5�      A� 5�   
   $��5��6   $��4��6#   .+�5�      �� -   5        $ cancle��5�      $��0��6%   $��C��65   $��10,5,87,-40q�5�      $��50(�5�      
��� ��� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��69   5�      5�      5�      �� 5�      -   5        $ cleare��5�      $��2��6%   $��CE��65   $��-57,5,149,-40q�5�      $��50(�5�      
��� ��� 5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 10��69   5�      5�      5�      5�      5�      5�      