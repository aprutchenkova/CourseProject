   M S B A M L   `   `   `  ����	  MyApp     MyApp.Views.WordListWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Список слов��5   	   $	��400��6   $	��400��6*   ���	#FFF1E1EF.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��51��6*   �� 5      �� 5	      $
��Auto �6   $��74��6*   .+�5   
   �� $��Список слов��6   $��22(�5      $
��Bold"�6"   $��Center=�5      $��Center=�61   $��
Constantia)�5      $��28��6,   $	��136��68   �� 5   
   $��1��6   
������� �� CornerRadius$ 10��61    �� Padding$ 10q�6C   $��10,10,10,10q�6P   ._�5      �� $
��Auto=�6   .��5      �� .+�5      �� ��6#   �� *Words+��5      �� 5      .R�5   "   �� $��
Constantia)�6I   $��12(�5   ,   $��0,5,0,5q�6:   ��5   ,   �� *EnglishWord+5   :   5      5      5      5      5      �� 5    
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��	0,10,0,10q�6X   $	��160��6k   .+�5!      �� $��54��6   $	��159��6%   .+�5"      �� $#��Решить карточки��6   $	��155��5$      $��30��6%   ���	#FFD9B4D5$��
Constantia)�6H   
���   ���5"   4   �� *StartCardCommand+��5#      ��  �� RelativeSource ��  �� AncestorType" ���5%      Z� 60   �� 5&      $��
Назад��6   $��70��5(      $��19��6$   ���	#FFD9B4D5$��
Constantia)�6G   $��Bottom=�5)   0   
���   �$��0,5,0,0q�6^   ��5&   )   �� *GoBackCommand+��5'      ��  �� " ���5)      Z� 6^   5*      5+      5,      5-      