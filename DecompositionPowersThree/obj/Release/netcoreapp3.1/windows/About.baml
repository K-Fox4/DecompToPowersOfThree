   M S B A M L   `   `   `  ���� S  ODecompositionPowersThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DecompositionPowersThree.windows DecompositionPowersThree.windows  ,    &DecompositionPowersThree.windows.About   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:DecompositionPowersThree.windows     -     �Name$  About_Window�� � Title$ About��$	��500��$	��600�����	#FF2C2C2C � 
ResizeMode$ CanMinimize=� � Icon$ /windows/4486894.png��.���  � ColumnDefinitions �� .+��� -    ��Name$ About_Content��$
��Left=�$	��415��$��	25,25,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��535�����	#FF2C2C2C
�������$��16(� �� 
IsReadOnly$
 True��$����
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
    43 = 81 - 27 - 9 - 3 + 1�� �� TextAlignment$ Justify=�