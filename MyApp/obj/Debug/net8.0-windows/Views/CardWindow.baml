   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyApp.ViewsMyApp.Views  5   	       MyApp.Views.CardWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MyApp.Views     5   	     � Title$  Карточка��5   	   $	��400��6   $	��400��6'   ���	#FFF1E1EF � 	Resources 5
          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      � .+�5   
   � $��
10,10,10,0q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��Карточки��6   $��22(�6(   $��
Constantia)�66   $
��Left=�5      $	��Top=�63   $��	142,8,0,0q�5      $��0��6+   $
��Bold"�6;   �� 5      $��x��6   
������ 
������ $��30��5      $��30��6    $��1��6,   $��Right=�5      $	��Top=�61   $��
Constantia)�6I   ��5   !   �� *GoBackCommand+��5      ��  �� RelativeSource ��  �� AncestorType" �5   I   5      �� 5   
   
������� �� CornerRadius$ 10��6$   $��20,60,20,80q�5       �� Padding$ 10q�6&   ._�5       �� .+�5!      �� $��24(�6E   $��Center=�5"      $��
Constantia)�69   $��	0,10,0,10q�6Q   ���	#FFBF8EBA��5!      �� *CurrentWord.EnglishWord+5"   d   �� 5$      $��16(�6I   $��Center=�5%      $��
Constantia)�69   $��	0,10,0,10q�6Q   $
��Wrap=�5&      ��5$      �� *CurrentWord.ExampleSentence+5&      �� 5(      $��
Constantia)�6E   $��18(�6]   $��Center=�5*      $��	0,10,0,10q�69   ��5(      �� *CurrentWord.Translation+y�5)      �� *IsTranslationVisible+ �� 	Converter# [  5*   9   �� 5,      $��
Constantia)�6T   $��18(�6l   $��Center=�5.      $��	0,10,0,10q�69   $
��Wrap=�5/      $	��350��60   ��5,      �� *(&CurrentWord.ExampleSentenceTranslation+y�5-      �� *IsTranslationVisible+# [  5/   0   50      51      �� 53   
   $%��Показать перевод��6   $	��150��54      $��30��6   $��
Constantia)�6)   ���	#FFD9B4D5
���   ����	#FFD9B4D5$��Center=�56      $��Bottom=�6.   $��0,0,0,40q�6I   ��53   ,   �� *ShowTranslationCommand+56   I   �� 58   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�59      $��0,5,0,5q�60   .+�5:      �� $��Предыдущая��6   ���	#FFD9B4D5
���   �
������ $	��100��5<      $��30��6!   $��0,0,10,0q�6-   $��
Constantia)�6?   ��5:   *   �� *PreviousCommand+5<   ?   �� 5=      $��Следующая��6   ���	#FFD9B4D5
���   �
������ $	��100��5?      $��30��6!   $��
Constantia)�6-   ��5=   )   �� *NextCommand+5?   -   5@      5A      5B      