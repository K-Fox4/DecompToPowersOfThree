   M S B A M L   `   `   `  ����S  ODecompositionPowersThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DecompositionPowersThree.windows DecompositionPowersThree.windows  5   	   ,    &DecompositionPowersThree.windows.About   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:DecompositionPowersThree.windows     5   	   -   5          �Name$  About_Window��5   	    � Title$ About��5   	   $	��500��6   $	��600��6$   ���	#FF2C2C2C � 
ResizeMode$ CanMinimize=�6G    � Icon$ /windows/4486894.png��6`   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ About_Content��5      $
��Left=�6)   $	��415��6D   $��	25,25,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��535��6�   ���	#FF2C2C2C
�������$��16(�6�    �� 
IsReadOnly$
 True��6�   $����
This application will help in decomposing an integer, as combination of sum (+) and difference (-) of distinct/unique powers of three, i.e. 1, 3, 9,  27 & 81, and any power of three will appear at most once in the decomposition of any integer.

Condition: 
Input integer is any integer in the interval [-121, 121], other than zero

Examples:

    1 = 1
    2 = 3 - 1
    3 = 3
    4 = 3 + 1
    7 = 9 - 3 + 1
    -14 = - 27 + 9 + 3 + 1
    -121 = - 81 - 27 - 9 - 3 - 1
    43 = 81 - 27 - 9 - 3 + 1��6�    �� TextAlignment$ Justify=�6M  5      5      