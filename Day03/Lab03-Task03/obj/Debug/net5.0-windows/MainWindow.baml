   M S B A M L   `   `   `  ����G  CLab03-Task03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lab03_Task03Lab03_Task03  5   	       Lab03_Task03.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lab03_Task03     5   	     � Title$  Simple-Editor��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%  '��       '�� �     �� 5
   
   " ��6   �5      �� 5       � ��$	 120��6*   68   �� 5       � ��$ 30��6+   68   �� 5       � ��$ 5q�6+   67   5      �� 5   
   " ��6   �5      �� 5       � ��$ Center=�6?   6P   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $
��1.5* �6   6,    � ColumnDefinitions 5   
   �� 5      6"   �� 5      6"   �� 5       6"   �� 5!      6"   .+�5#   
   �� -   5         ��Name$ cmbFont��5#      $��0��6$   $��0��61   .@�5&      �� $��12��6    �� 
IsSelected$
 True��6(   6<   �� 5'      $��16��6   6*   �� 5(      $��20��6   6*   �� 5)      $��25��6   6*   �� 5*      $��40��6   6*   �� 5+      $��50��6   6*   �� 5,      $��60��6   6*   �� 5-      $��65��6   6*   5.      �� 5/   
   -   5        $ cmbColor��5/      $��0��6%   $��1��62   .@�50      �� $	��Red��6   
���  ��$
 True��6:   6N   �� 51      $
��Blue��6   
����  �6>   �� 52      $��Yellow��6   
��� ���6B   �� 53      $��	BurlyWood��6   
�������6H   �� 54      $��Lavander��6   
�������6F   55      �� 56   
   -   5        $ cmbAligment��56      $��0��6(   $��2��65   .@�57      �� $��Center��6   6/   �� 58      $
��Left��6   $
��Left=�6*   $
 True��6E   6Y   �� 59      $��Right��6   $��Right=�6+   6I   �� 5:      $��Justify��6   $
��Left=�6-   6J   5;      �� 5<   
   -   5        	 ��Name$	 btnReadOnly��5<      $��0��6(   $��3��5=      $��Enable��6#   $��10q�5>      5A      �� 5B   
   -   5        
 ��Name$
 	borderTxt��5B      $��1��6$   $��4��61   
����·�$��5q�6[    �� CornerRadius$ 10��6o   ._�5C      �� -   5         ��Name$
 txt1��5C       �� 
IsReadOnly$
 True��5D      ��5E      ��  �� ElementName$ cmbFont�� �� Path$ SelectionBoxItem���5F      �� $ cmbColor��$ SelectionBoxItem� �� TextAlignment 5G      �� $ cmbAligment��$ SelectionBoxItem�5H      5I      5K      5L      