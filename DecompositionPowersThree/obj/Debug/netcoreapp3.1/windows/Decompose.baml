   M S B A M L   `   `   `  ����S  ODecompositionPowersThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DecompositionPowersThree.windows DecompositionPowersThree.windows  5   	   0    *DecompositionPowersThree.windows.Decompose   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:DecompositionPowersThree.windows     5   	   -   5          �Name$  Decompose_Window��5   	    � Title$ 	Decompose��5   	   $	��550��6   $	��600��6(   ���	#FF2C2C2C
������� � 
ResizeMode$ CanMinimize=�6^    � Icon$ 4486894.png��6w   .��5	      � .+�5
   
   �� -   5         ��Name$ Decompose_Message_Box��5
      $
��Left=�61   $��50��6L   $��
25,225,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��535��6�   ���	#FF2C2C2C
������� �� 
IsReadOnly$
 True��6�   $��16(�6�   $��Center=�6�   $��Center=�6  
�������$
��Bold"�6x  �� 5   
   -   5         ��Name$ Decompose_Message_Label��5      $��Message:��61   $
��Left=�6D   $��35��6_   $��
20,185,0,0q�6k   $	��Top=�6   $��95��6�   
�������$��16(�6�   $��Center=�6�   �� 5   
   -   5        $! Decompose_Decomposition_Box��5      $
��Left=�67   $��50��6R   $��
25,125,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��535��6�   $
 True��6�   $��24(�6�   ���	#FF2C2C2C
�������$��Center=�6�   $��Center=�6  $
��Bold"�6:  $��Italic$�6L  
�������6�  �� 5   
   -   5        $# Decompose_Decomposition_Label��5      $��Decomposition:��67   $
��Left=�6P   $��35��6k   $��	20,85,0,0q�6w   $	��Top=�6�   $	��120��6�   
�������$��16(�6�   �� 5   
   -   5        $ Decompose_Integer_Label��5      $��Integer:��61   $
��Left=�6D   $��35��6_   $��	60,25,0,0q�6k   $	��Top=�6~   $��90��6�   
�������$��16(�6�   $��Center=�6�   �� 5   
   -   5        $! Decompose_Integer_Input_Box��5      $
��Left=�67   $��35��6R   $��
140,25,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $��90��6�   
�������$��Center=�6�   $��Center=�6�   $��16(�6  ���	#FF2C2C2C
������� � Cursor$ IBeam��6q  �� 5   
   -   5        	 ��Name$ 	 Decompose_Decompose_Button��5      $��	Decompose��65   $
��Left=�6I   $��35��6d   $��
280,25,0,0q�6p   $	��Top=�6�   $	��105��6�   ���	#FF2C2C2C$��16(�6�   
�������$
 Hand��6	  ��5      �� 5      
 �� EndPoint$
 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ Black��6#   � 5      $ White��6#    � Offset$ 1Q�61   5      5      �� 5   
   -	   5        $" Decompose_Instructions_Label��5      $��Instructions:��66   $
��Left=�6N   $��35��6i   $��
20,285,0,0q�6u   $	��Top=�6�   $	��100��6�   
�������$��16(�6�   �� 5   
   -
   5        $  Decompose_Instructions_Box��5      $
��Left=�66   $	��150��6Q   $��
25,325,0,0q�6^   $
 Wrap=�6r   $����• Enter an non-zero Integer, which lies in the range between -121 and 121 (both included), in box next to 'Integer' label
• Click 'Decompose' button to decompose the integer
• Once decomposition is complete, decomposed data will be displayed in the box below 'Decomposition' label
• If there is any message, it will be displayed in the box below 'Message' label
• Click 'Refresh' button, for refreshing all fields��6�   $	��Top=�6@  $	��535��6X  ���	#FF2C2C2C
�������$��14(�6�  $��Center=�6�  
�������6�  �� 5   
   -   5        $	 Decompose_Repeat_Button��5      $
��Left=�62   $��35��6M   $��
440,25,0,0q�6Y   $	��Top=�6m   $��35��6�   ���	#FF2C2C2C$
 Hand��6�   ��5      �� 5      $
 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ White��6#   $ 1Q�61   5      .��5!      �� -   5         ��Name$ Decompose_Repeat_Image��5!      $��25��64   $��25��6@   $
 Hand��6K   $'��!/windows/media_repeat_alt_inv.png��6Y   5"      5$      5%      