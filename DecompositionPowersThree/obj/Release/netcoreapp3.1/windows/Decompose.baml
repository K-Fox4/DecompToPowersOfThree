   M S B A M L   `   `   `  ���� S  ODecompositionPowersThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DecompositionPowersThree.windows DecompositionPowersThree.windows  0    *DecompositionPowersThree.windows.Decompose   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:DecompositionPowersThree.windows     -     �Name$  Decompose_Window�� � Title$ 	Decompose��$	��550��$	��600�����	#FF2C2C2C
������� � 
ResizeMode$ CanMinimize=� � Icon$ 4486894.png��.��� .+��� -    ��Name$ Decompose_Message_Box��$
��Left=�$��50��$��
25,225,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��535�����	#FF2C2C2C
������� �� 
IsReadOnly$
 True��$��16(�$��Center=�$��Center=�
�������$
��Bold"��� -    ��Name$ Decompose_Message_Label��$��Message:��$
��Left=�$��35��$��
20,185,0,0q�$	��Top=�$��95��
�������$��16(�$��Center=��� -   $! Decompose_Decomposition_Box��$
��Left=�$��50��$��
25,125,0,0q�$
 Wrap=�$	��Top=�$	��535��$
 True��$��24(����	#FF2C2C2C
�������$��Center=�$��Center=�$
��Bold"�$��Italic$�
��������� -   $# Decompose_Decomposition_Label��$��Decomposition:��$
��Left=�$��35��$��	20,85,0,0q�$	��Top=�$	��120��
�������$��16(��� -   $ Decompose_Integer_Label��$��Integer:��$
��Left=�$��35��$��	60,25,0,0q�$	��Top=�$��90��
�������$��16(�$��Center=��� -   $! Decompose_Integer_Input_Box��$
��Left=�$��35��$��
140,25,0,0q�$
 Wrap=�$	��Top=�$��90��
�������$��Center=�$��Center=�$��16(����	#FF2C2C2C
������� � Cursor$ IBeam���� -   	 ��Name$ 	 Decompose_Decompose_Button��$��	Decompose��$
��Left=�$��35��$��
280,25,0,0q�$	��Top=�$	��105�����	#FF2C2C2C$��16(�
�������$
 Hand������ 
 �� EndPoint$
 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ White�� � Offset$ 1Q��� -	   $" Decompose_Instructions_Label��$��Instructions:��$
��Left=�$��35��$��
20,285,0,0q�$	��Top=�$	��100��
�������$��16(��� -
   $  Decompose_Instructions_Box��$
��Left=�$	��150��$��
25,325,0,0q�$
 Wrap=�$����• Enter an non-zero Integer, which lies in the range between -121 and 121 (both included), in box next to 'Integer' label
• Click 'Decompose' button to decompose the integer
• Once decomposition is complete, decomposed data will be displayed in the box below 'Decomposition' label
• If there is any message, it will be displayed in the box below 'Message' label
• Click 'Refresh' button, for refreshing all fields��$	��Top=�$	��535�����	#FF2C2C2C
�������$��14(�$��Center=�
��������� -   $	 Decompose_Repeat_Button��$
��Left=�$��35��$��
440,25,0,0q�$	��Top=�$��35�����	#FF2C2C2C$
 Hand������ $
 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q�.���� -    ��Name$ Decompose_Repeat_Image��$��25��$��25��$
 Hand��$'��!/windows/media_repeat_alt_inv.png��