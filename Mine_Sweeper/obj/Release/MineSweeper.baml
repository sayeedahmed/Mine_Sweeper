   M S B A M L   `   `   `  ���� G  CMine_Sweeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Mine_SweeperMine_Sweeper      Mine_Sweeper.MineSweeper   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Mine_Sweeper       � Icon$  Resources/Images/mine.bmp�� � Title$ MineSweeper��$	��550��$	��500��$	��500��$	��550��.��� -    �Name$ gridApp��.+��� -    ��Name$ groupBoxDifficulty��$��
Difficulty��$
��Left=�$��	50,18,0,0q�$	��Top=�$	��226��$��60��	� -    	�Name$ radioButtonLow��$��Newbie��$
��Left=�$��	71,44,0,0q�$	��Top=� d� 	IsChecked$
 TrueY�	� -   $ radioButtonMedium��$��Amatuer��$
��Left=�$��
142,44,0,0q�$	��Top=�	� -   $ radioButtonHigh��$	��Pro��$
��Left=�$��
229,44,0,0q�$	��Top=��� -    ��Name$ 
buttonPlay��$
��Play��$
��Left=�$��
294,27,0,0q�$	��Top=�$	��112��$��48������  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color$
 	#FFF3F3F3��� $
 	#FFEBEBEB�� � Offset$	 0.5Q�� $
 	#FFDDDDDD��$	 0.5Q�� $
 	#FFCDCDCD��$ 1Q�� -   $ 
layoutGrid��$
��Left=�$	��350��$��
56,128,0,0q�$	��Top=�$	��350��$	��350��$	��353���� -    ��Name$ labelWon��$
��Won:��$��
272,98,0,0q� J� RenderTransformOrigin$ 0.495,0.515&�$
��Left=�$��42��$��26��$	��Top=�$��Meiryo)�$
��Bold"��� -	   $ labelWonScore��$��0��$��
311,98,0,0q�$ 1.031,0.359&�$��26��$	��Top=�$
��Left=�$��28��$��Meiryo)�$
��Bold"��� -
   $ 	labelLost��$��Lost:��$��
344,98,0,0q�$ 0.535,0.546&�$
��Left=�$��40��$��26��$	��Top=�$��Meiryo)�$
��Bold"��� -   $ labelLostScore��$��0��$��
381,98,0,0q�$��26��$	��Top=�$
��Left=�$��26��$��Meiryo)�$
��Bold"��� -   $ textBlockContact��$��Right=�$��0,0,81.6,2.4q�$��Bottom=�.���� -   $H��Bmailto:sayeedahmed.1310@gmail.com?subject=MineSweeper App Feedback?�.�Contact Developer�� -    ��Name$ 	imageFlag��$��Resources/Images/flag.png��$
��Left=�$��26��$��	75,94,0,0q�$	��Top=�$��26���� -   $ labelSeparator��$��:��$
��Left=�$��
101,94,0,0q�$	��Top=�$��Meiryo)�$��16(�$
��Bold"��� -   $ labelFlagCounter��$��0��$
��Left=�$��
116,94,0,0q�$	��Top=�$��Meiryo)�$��16(�$
��Bold"��� $��1q�$
��Left=�$��26��$��
171,96,0,0q�$	��Top=�$��73�� J� Opacity$	 0.5Q� �� CornerRadius$ 5������ $ 0.5,1&�$ RelativeToBoundingBox=�$	 0.5,0&� � SpreadMethod$ Repeat=�.��� $
 	#FFF9F6F6��$ 1Q�� $
 	#FF2952B1����
� .��� $
 Black��$ 0Q�� $
 	#FF9A4F4F��$ 1Q��� -   $ 
labelTimer��$��00:00��$
��Left=�$��
178,94,0,0q�$	��Top=�$��16(�$��Meiryo)�$
��Bold"�$��28���� -   $ groupBoxScore��$��Score��$
��Left=�$��46��$��
263,82,0,0q�$	��Top=�$	��144�� � 	Resources    gridButtonStyle �� Property �� Value��%?   &	        �� .���  � ��
 ��+����  � ��$ 1q�